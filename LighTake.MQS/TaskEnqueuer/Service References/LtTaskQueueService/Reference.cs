﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MQS_TaskEnqueuer.LtTaskQueueService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LtTaskQueueService.ILtTaskQueue")]
    public interface ILtTaskQueue {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILtTaskQueue/AddTaskQueue", ReplyAction="http://tempuri.org/ILtTaskQueue/AddTaskQueueResponse")]
        bool AddTaskQueue(string queueName, string[] values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILtTaskQueue/WaitAddTaskQueue", ReplyAction="http://tempuri.org/ILtTaskQueue/WaitAddTaskQueueResponse")]
        bool WaitAddTaskQueue(int timeOut);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILtTaskQueueChannel : MQS_TaskEnqueuer.LtTaskQueueService.ILtTaskQueue, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LtTaskQueueClient : System.ServiceModel.ClientBase<MQS_TaskEnqueuer.LtTaskQueueService.ILtTaskQueue>, MQS_TaskEnqueuer.LtTaskQueueService.ILtTaskQueue {
        
        public LtTaskQueueClient() {
        }
        
        public LtTaskQueueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LtTaskQueueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LtTaskQueueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LtTaskQueueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddTaskQueue(string queueName, string[] values) {
            return base.Channel.AddTaskQueue(queueName, values);
        }
        
        public bool WaitAddTaskQueue(int timeOut) {
            return base.Channel.WaitAddTaskQueue(timeOut);
        }
    }
}
