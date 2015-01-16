﻿// Decompiled with JetBrains decompiler
// Type: ParallelTasks.Task
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 98EC8A66-D3FB-4994-A617-48E1C71F8818
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System;

namespace ParallelTasks
{
    public struct Task
    {
        public bool valid;

        internal WorkItem Item { get; private set; }

        internal int ID { get; private set; }

        public bool IsComplete
        {
            get
            {
                if (this.valid)
                    return this.Item.RunCount != this.ID;
                else
                    return true;
            }
        }

        public Exception[] Exceptions
        {
            get
            {
                if (!this.valid || !this.IsComplete)
                    return (Exception[]) null;
                Exception[] data;
                this.Item.Exceptions.TryGet(this.ID, out data);
                return data;
            }
        }

        internal Task(WorkItem item)
        {
            this = new Task();
            this.ID = item.RunCount;
            this.Item = item;
            this.valid = true;
        }

        public void Wait()
        {
            if (!this.valid)
                return;
            Task? currentTask = WorkItem.CurrentTask;
            if (currentTask.HasValue && currentTask.Value.Item == this.Item && currentTask.Value.ID == this.ID)
                throw new InvalidOperationException("A task cannot wait on itself.");
            this.Item.Wait(this.ID);
        }

        internal void DoWork()
        {
            if (!this.valid)
                return;
            this.Item.DoWork(this.ID);
        }
    }
}