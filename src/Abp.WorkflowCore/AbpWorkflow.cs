﻿using Abp.Dependency;
using Abp.Workflow;
using WorkflowCore.Interface;

namespace Abp.WorkflowCore
{
    public abstract class AbpWorkflow : IAbpWorkflow, ISingletonDependency
    {
        public string Id { get; set; }

        public int Version { get; set; }

        public abstract void Build(IWorkflowBuilder<WorkflowParamDictionary> builder);
    }

}
