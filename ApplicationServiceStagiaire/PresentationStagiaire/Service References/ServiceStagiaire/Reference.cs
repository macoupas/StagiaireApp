﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationStagiaire.ServiceStagiaire {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceStagiaire.IServiceStagiaire")]
    public interface IServiceStagiaire {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListAllStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/ListAllStagiaireResponse")]
        Core.ResponseData<Core.StagiaireDTO[]> ListAllStagiaire();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListAllStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/ListAllStagiaireResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO[]>> ListAllStagiaireAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteStagiaireResponse")]
        Core.ResponseData<bool> DeleteStagiaire(Core.StagiaireDTO stagiaireToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteStagiaireResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> DeleteStagiaireAsync(Core.StagiaireDTO stagiaireToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetStagiaireById", ReplyAction="http://tempuri.org/IServiceStagiaire/GetStagiaireByIdResponse")]
        Core.ResponseData<Core.StagiaireDTO> GetStagiaireById(int stagiaireId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetStagiaireById", ReplyAction="http://tempuri.org/IServiceStagiaire/GetStagiaireByIdResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO>> GetStagiaireByIdAsync(int stagiaireId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/UpdateExistingStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/UpdateExistingStagiaireResponse")]
        Core.ResponseData<bool> UpdateExistingStagiaire(Core.StagiaireDTO stagiaireToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/UpdateExistingStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/UpdateExistingStagiaireResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> UpdateExistingStagiaireAsync(Core.StagiaireDTO stagiaireToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/AddStagiaireResponse")]
        Core.ResponseData<bool> AddStagiaire(Core.StagiaireDTO stagiaireToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddStagiaire", ReplyAction="http://tempuri.org/IServiceStagiaire/AddStagiaireResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> AddStagiaireAsync(Core.StagiaireDTO stagiaireToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListAllTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/ListAllTuteurResponse")]
        Core.ResponseData<Core.TuteurDTO[]> ListAllTuteur();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListAllTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/ListAllTuteurResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<Core.TuteurDTO[]>> ListAllTuteurAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteTuteurResponse")]
        Core.ResponseData<bool> DeleteTuteur(Core.TuteurDTO tuteurToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteTuteurResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> DeleteTuteurAsync(Core.TuteurDTO tuteurToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetTuteurById", ReplyAction="http://tempuri.org/IServiceStagiaire/GetTuteurByIdResponse")]
        Core.ResponseData<Core.TuteurDTO> GetTuteurById(int tuteurId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/GetTuteurById", ReplyAction="http://tempuri.org/IServiceStagiaire/GetTuteurByIdResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<Core.TuteurDTO>> GetTuteurByIdAsync(int tuteurId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/UpdateExistingTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/UpdateExistingTuteurResponse")]
        Core.ResponseData<bool> UpdateExistingTuteur(Core.TuteurDTO tuteurToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/UpdateExistingTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/UpdateExistingTuteurResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> UpdateExistingTuteurAsync(Core.TuteurDTO tuteurToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/AddTuteurResponse")]
        Core.ResponseData<bool> AddTuteur(Core.TuteurDTO tuteurToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/AddTuteurResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> AddTuteurAsync(Core.TuteurDTO tuteurToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddStagiaireToTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/AddStagiaireToTuteurResponse")]
        Core.ResponseData<bool> AddStagiaireToTuteur(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/AddStagiaireToTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/AddStagiaireToTuteurResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> AddStagiaireToTuteurAsync(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteStagiaireOfTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteStagiaireOfTuteurResponse")]
        Core.ResponseData<bool> DeleteStagiaireOfTuteur(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/DeleteStagiaireOfTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/DeleteStagiaireOfTuteurResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<bool>> DeleteStagiaireOfTuteurAsync(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListStagiaireOfTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/ListStagiaireOfTuteurResponse")]
        Core.ResponseData<Core.StagiaireDTO[]> ListStagiaireOfTuteur(Core.TuteurDTO tuteurToGetStagiaire);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStagiaire/ListStagiaireOfTuteur", ReplyAction="http://tempuri.org/IServiceStagiaire/ListStagiaireOfTuteurResponse")]
        System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO[]>> ListStagiaireOfTuteurAsync(Core.TuteurDTO tuteurToGetStagiaire);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceStagiaireChannel : PresentationStagiaire.ServiceStagiaire.IServiceStagiaire, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceStagiaireClient : System.ServiceModel.ClientBase<PresentationStagiaire.ServiceStagiaire.IServiceStagiaire>, PresentationStagiaire.ServiceStagiaire.IServiceStagiaire {
        
        public ServiceStagiaireClient() {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStagiaireClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStagiaireClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Core.ResponseData<Core.StagiaireDTO[]> ListAllStagiaire() {
            return base.Channel.ListAllStagiaire();
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO[]>> ListAllStagiaireAsync() {
            return base.Channel.ListAllStagiaireAsync();
        }
        
        public Core.ResponseData<bool> DeleteStagiaire(Core.StagiaireDTO stagiaireToDelete) {
            return base.Channel.DeleteStagiaire(stagiaireToDelete);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> DeleteStagiaireAsync(Core.StagiaireDTO stagiaireToDelete) {
            return base.Channel.DeleteStagiaireAsync(stagiaireToDelete);
        }
        
        public Core.ResponseData<Core.StagiaireDTO> GetStagiaireById(int stagiaireId) {
            return base.Channel.GetStagiaireById(stagiaireId);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO>> GetStagiaireByIdAsync(int stagiaireId) {
            return base.Channel.GetStagiaireByIdAsync(stagiaireId);
        }
        
        public Core.ResponseData<bool> UpdateExistingStagiaire(Core.StagiaireDTO stagiaireToUpdate) {
            return base.Channel.UpdateExistingStagiaire(stagiaireToUpdate);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> UpdateExistingStagiaireAsync(Core.StagiaireDTO stagiaireToUpdate) {
            return base.Channel.UpdateExistingStagiaireAsync(stagiaireToUpdate);
        }
        
        public Core.ResponseData<bool> AddStagiaire(Core.StagiaireDTO stagiaireToAdd) {
            return base.Channel.AddStagiaire(stagiaireToAdd);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> AddStagiaireAsync(Core.StagiaireDTO stagiaireToAdd) {
            return base.Channel.AddStagiaireAsync(stagiaireToAdd);
        }
        
        public Core.ResponseData<Core.TuteurDTO[]> ListAllTuteur() {
            return base.Channel.ListAllTuteur();
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<Core.TuteurDTO[]>> ListAllTuteurAsync() {
            return base.Channel.ListAllTuteurAsync();
        }
        
        public Core.ResponseData<bool> DeleteTuteur(Core.TuteurDTO tuteurToDelete) {
            return base.Channel.DeleteTuteur(tuteurToDelete);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> DeleteTuteurAsync(Core.TuteurDTO tuteurToDelete) {
            return base.Channel.DeleteTuteurAsync(tuteurToDelete);
        }
        
        public Core.ResponseData<Core.TuteurDTO> GetTuteurById(int tuteurId) {
            return base.Channel.GetTuteurById(tuteurId);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<Core.TuteurDTO>> GetTuteurByIdAsync(int tuteurId) {
            return base.Channel.GetTuteurByIdAsync(tuteurId);
        }
        
        public Core.ResponseData<bool> UpdateExistingTuteur(Core.TuteurDTO tuteurToUpdate) {
            return base.Channel.UpdateExistingTuteur(tuteurToUpdate);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> UpdateExistingTuteurAsync(Core.TuteurDTO tuteurToUpdate) {
            return base.Channel.UpdateExistingTuteurAsync(tuteurToUpdate);
        }
        
        public Core.ResponseData<bool> AddTuteur(Core.TuteurDTO tuteurToAdd) {
            return base.Channel.AddTuteur(tuteurToAdd);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> AddTuteurAsync(Core.TuteurDTO tuteurToAdd) {
            return base.Channel.AddTuteurAsync(tuteurToAdd);
        }
        
        public Core.ResponseData<bool> AddStagiaireToTuteur(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToAdd) {
            return base.Channel.AddStagiaireToTuteur(tuteurToUpdate, stagiaireToAdd);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> AddStagiaireToTuteurAsync(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToAdd) {
            return base.Channel.AddStagiaireToTuteurAsync(tuteurToUpdate, stagiaireToAdd);
        }
        
        public Core.ResponseData<bool> DeleteStagiaireOfTuteur(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToDelete) {
            return base.Channel.DeleteStagiaireOfTuteur(tuteurToUpdate, stagiaireToDelete);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<bool>> DeleteStagiaireOfTuteurAsync(Core.TuteurDTO tuteurToUpdate, Core.StagiaireDTO stagiaireToDelete) {
            return base.Channel.DeleteStagiaireOfTuteurAsync(tuteurToUpdate, stagiaireToDelete);
        }
        
        public Core.ResponseData<Core.StagiaireDTO[]> ListStagiaireOfTuteur(Core.TuteurDTO tuteurToGetStagiaire) {
            return base.Channel.ListStagiaireOfTuteur(tuteurToGetStagiaire);
        }
        
        public System.Threading.Tasks.Task<Core.ResponseData<Core.StagiaireDTO[]>> ListStagiaireOfTuteurAsync(Core.TuteurDTO tuteurToGetStagiaire) {
            return base.Channel.ListStagiaireOfTuteurAsync(tuteurToGetStagiaire);
        }
    }
}
