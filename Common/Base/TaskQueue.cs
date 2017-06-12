using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Base
{
    public class TaskQueue : ConcurrentQueue<Task>
    {
        private bool isRunning;
        private Task executeTask;
        private CancellationTokenSource tokeSource;

        public TaskQueue()
        {
            tokeSource = new CancellationTokenSource();

            executeTask = new Task(StartTask, tokeSource.Token, TaskCreationOptions.LongRunning);
            this.executeTask.Start();
        }

        private void StartTask()
        {
            while (true)
            {
                if (isRunning || this.Count == 0)
                {
                    Thread.Sleep(500);
                    continue;
                }

                Task task;
                if (this.TryDequeue(out task))
                {
                    if (task == null)
                    {
                        continue;
                    }
                    this.isRunning = true;
                    task.ContinueWith((t) =>
                    {
                        this.isRunning = false;
                    });
                    task.Start();
                }
            }
        }
    }
}
