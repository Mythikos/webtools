using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebToolsCore.Threading
{
    public class TaskQueue
    {
        private List<Task> _pendingTasks;

        public int MaxConcurrency { get; set; }
        public int PendingTasks { get { return this._pendingTasks?.Count(x => x.IsCompleted == false) ?? 0; } }
        public int CompletedTasks { get { return this._pendingTasks?.Count(x => x.Status == TaskStatus.RanToCompletion) ?? 0; } }
        public int FaultedTasks { get { return this._pendingTasks?.Count(x => x.Status == TaskStatus.Faulted) ?? 0; } }
        public int CancelledTasks { get { return this._pendingTasks?.Count(x => x.Status == TaskStatus.Canceled) ?? 0; } }
        public int FinishedTasks { get { return this.CompletedTasks + this.FaultedTasks + this.CancelledTasks; } }

        public event Action OnProgressChange;

        public TaskQueue(int maxConcurrency = 1)
        {
            this.MaxConcurrency = maxConcurrency;
            this._pendingTasks = new List<Task>();
        }

        public async Task Process(List<Task> tasks)
        {
            this._pendingTasks = tasks;

            var runningTasks = new List<Task>(this.MaxConcurrency);
            foreach (var task in this._pendingTasks)
            {
                if (task == null)
                    continue;

                runningTasks.Add(task);
                task.Start();

                if (runningTasks.Count == this.MaxConcurrency)
                {
                    await Task.WhenAny(runningTasks.ToArray());
                    runningTasks.RemoveAll(x => x.IsCompleted);
                    this.OnProgressChange?.Invoke();
                }
            }

            await Task.WhenAll(runningTasks.ToArray());
        }
    }
}
