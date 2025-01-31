﻿
namespace BP.ACoE.ChatBotHelper.Models
{
    public enum AppInsightCustomEventTypes
    {
        SalesForceChatTranscriptStarted,
        SalesForceLiveAgentSessionConnected,
        SalesForceIssue,
        SF_PromoRewardsWebform_Started,
        SF_PromoRewardsWebform_Response,
        WebForm_Summited,
        SF_HandoffFail_NoWebform,
        SF_HandoffFail_WebformSubmit,
        SF_Handoff_CaseCreationSuccessful,
        SF_Handoff_CaseCreationStarted,
        SF_Handoff_AuthenticationStarted,
        SF_CreationSuccessful_Update_AuthenticationStarted,
        SF_Handoff_AuthenticationSuccessful,
        SF_GetTranscripts_AuthenticationStarted,
        SF_GetTranscripts_AuthenticationSuccessful,
        SF_UpdateTranscripts_AuthenticationStarted,
        SF_UpdateTranscripts_AuthenticationSuccessful,
        SF_CreateTranscripts_AuthenticationStarted,
        SF_CreateTranscripts_AuthenticationSuccessful,
        SF_Get_CaseCreationSuccessful_TranscriptsStarted,
        SF_Get_CaseCreationSuccessful_TranscriptsReceived,
        SF_Get_HandOffFailed_TranscriptsStarted,
        SF_Get_HandOffFailed_TranscriptsReceived,
        SF_Get_HandOffFailureWebformSubmit_TranscriptsStarted,
        SF_Get_HandOffFailureWebformSubmit_TranscriptsReceived,
        SF_CaseCreationSuccessful_TranscriptsUpdateStarted,
        SF_CaseCreationSuccessful_TranscriptsUpdated,
        SF_CaseCreationSuccessful_TranscriptsCreationStarted,
        SF_CaseCreationSuccessful_TranscriptsCreated,
        SF_HandOffFailed_TranscriptsUpdateStarted,
        SF_HandOffFailed_TranscriptsUpdated,
        SF_HandOffFailed_TranscriptsCreationStarted,
        SF_HandOffFailed_TranscriptsCreated,
        SF_HandOffFailureWebformSubmit_TranscriptsUpdateStarted,
        SF_HandOffFailureWebformSubmit_TranscriptsUpdated,
        SF_HandOffFailureWebformSubmit_TranscriptsCreationStarted,
        SF_HandOffFailureWebformSubmit_TranscriptsCreated,
        SF_HandOffFailureWebformSubmit_UpdateWebform_AuthenticationStarted,
        SF_WebformSubmit_AuthenticationSuccessful,
        SF_WebformSubmit_ProcessedSuccessfully,
        SP_WebformSubmit_TranscriptUploadStarted,
        SP_WebformSubmit_TranscriptUploaded,
        SF_HappyPath_TranscriptUploadStarted,
        SF_HappyPath_TranscriptUploadSuccessful,
        SF_CreationSuccessful_Update_AuthenticationSuccessful,
        SF_WebformSubmit_AuthenticationStarted,
        SF_HappyPath_AuthenticationStarted,
        SF_HappyPath_ProcessedSuccessfully,
        SF_HappyPath_AuthenticationSuccessful,
        SF_HandOffFailureWebformSubmit_AuthenticationSuccessful,
        SF_HandOffFailed_UpdateAndCloseCase_AuthenticationSuccessful,
        SF_HandOffCaseCreationalSuccessful,
        SF_WebformCaseCreationalSuccessful,
        SF_HappyPathCreationalSuccessful,
        SendChatTranscriptTelemetry,
        SF_LiveAgentSessionConnected,
        SF_CaseCreationSuccessful_UpdateSuccessful,
        SF_HandOffFailed_UpdateAndClose_AuthenticationStarted,
        SF_HandOffFailed_UpdateAndCloseSuccessful,
        SF_HandOffFailureWebformSubmit_UpdateWebformSuccessful,
        SF_ChatTranscriptStarted,
        SF_SalesforceIssue,
        ConversationStarted,
        ConversationProcessed,
        ConversationRemovedFromJobQuery,
        ConversationAddedToJobQueue,
        GenericEvent
    }
}
