using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Infrustructure.Data.Models;

namespace Sonali.API.Infrustructure.Data.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AaccAdjust21> AaccAdjust21s { get; set; }

    public virtual DbSet<AaccAdjust21Pr> AaccAdjust21Prs { get; set; }

    public virtual DbSet<AboutU> AboutUs { get; set; }

    public virtual DbSet<AccBankCheque> AccBankCheques { get; set; }

    public virtual DbSet<AccBankPayForwarding> AccBankPayForwardings { get; set; }

    public virtual DbSet<AccBasic> AccBasics { get; set; }

    public virtual DbSet<AccCashTemp> AccCashTemps { get; set; }

    public virtual DbSet<AccCfsetting> AccCfsettings { get; set; }

    public virtual DbSet<AccChart> AccCharts { get; set; }

    public virtual DbSet<AccChartC> AccChartCs { get; set; }

    public virtual DbSet<AccChartDetail> AccChartDetails { get; set; }

    public virtual DbSet<AccChartDetailAppAgent> AccChartDetailAppAgents { get; set; }

    public virtual DbSet<AccClosingTbl> AccClosingTbls { get; set; }

    public virtual DbSet<AccDetailTransaction> AccDetailTransactions { get; set; }

    public virtual DbSet<AccExpense> AccExpenses { get; set; }

    public virtual DbSet<AccGl2012> AccGl2012s { get; set; }

    public virtual DbSet<AccGl2013> AccGl2013s { get; set; }

    public virtual DbSet<AccGl2013C> AccGl2013Cs { get; set; }

    public virtual DbSet<AccGl2014> AccGl2014s { get; set; }

    public virtual DbSet<AccGl2014C> AccGl2014Cs { get; set; }

    public virtual DbSet<AccGl2015> AccGl2015s { get; set; }

    public virtual DbSet<AccGl2015C> AccGl2015Cs { get; set; }

    public virtual DbSet<AccGl2016> AccGl2016s { get; set; }

    public virtual DbSet<AccGl2016C> AccGl2016Cs { get; set; }

    public virtual DbSet<AccGl2017C> AccGl2017Cs { get; set; }

    public virtual DbSet<AccGl2018C> AccGl2018Cs { get; set; }

    public virtual DbSet<AccGl2019C> AccGl2019Cs { get; set; }

    public virtual DbSet<AccGl2023BkOct> AccGl2023BkOcts { get; set; }

    public virtual DbSet<AccJrlEditConfig> AccJrlEditConfigs { get; set; }

    public virtual DbSet<AccKfi> AccKfis { get; set; }

    public virtual DbSet<AccKfimanual> AccKfimanuals { get; set; }

    public virtual DbSet<AccKfiold> AccKfiolds { get; set; }

    public virtual DbSet<AccLedgerAccess> AccLedgerAccesses { get; set; }

    public virtual DbSet<AccRcpsetting> AccRcpsettings { get; set; }

    public virtual DbSet<AccRoi> AccRois { get; set; }

    public virtual DbSet<AccRptSetting> AccRptSettings { get; set; }

    public virtual DbSet<AccTempCheck> AccTempChecks { get; set; }

    public virtual DbSet<AccTransTemp> AccTransTemps { get; set; }

    public virtual DbSet<AccUpdateList> AccUpdateLists { get; set; }

    public virtual DbSet<AccUpdateListNew> AccUpdateListNews { get; set; }

    public virtual DbSet<AccUserRole> AccUserRoles { get; set; }

    public virtual DbSet<AccUserRoleMap> AccUserRoleMaps { get; set; }

    public virtual DbSet<AccVoucherAuth> AccVoucherAuths { get; set; }

    public virtual DbSet<AccVoucherReferral> AccVoucherReferrals { get; set; }

    public virtual DbSet<Accgl2017> Accgl2017s { get; set; }

    public virtual DbSet<Accgl2018> Accgl2018s { get; set; }

    public virtual DbSet<Accgl2019> Accgl2019s { get; set; }

    public virtual DbSet<Accgl2020> Accgl2020s { get; set; }

    public virtual DbSet<Accgl2020C> Accgl2020Cs { get; set; }

    public virtual DbSet<Accgl2021> Accgl2021s { get; set; }

    public virtual DbSet<Accgl20211> Accgl20211s { get; set; }

    public virtual DbSet<Accgl2021C> Accgl2021Cs { get; set; }

    public virtual DbSet<Accgl2022> Accgl2022s { get; set; }

    public virtual DbSet<Accgl20221> Accgl2022s1 { get; set; }

    public virtual DbSet<Accgl2022C> Accgl2022Cs { get; set; }

    public virtual DbSet<Accgl2022R> Accgl2022Rs { get; set; }

    public virtual DbSet<Accgl2022R2> Accgl2022R2s { get; set; }

    public virtual DbSet<Accgl2022R3> Accgl2022R3s { get; set; }

    public virtual DbSet<Accgl2022R4> Accgl2022R4s { get; set; }

    public virtual DbSet<Accgl2022R6jul> Accgl2022R6juls { get; set; }

    public virtual DbSet<Accgl2022d> Accgl2022ds { get; set; }

    public virtual DbSet<Accgl2023> Accgl2023s { get; set; }

    public virtual DbSet<Accgl2023Bkp> Accgl2023Bkps { get; set; }

    public virtual DbSet<Accgl2023C> Accgl2023Cs { get; set; }

    public virtual DbSet<Accgl2024> Accgl2024s { get; set; }

    public virtual DbSet<Accgl2024C> Accgl2024Cs { get; set; }

    public virtual DbSet<Accgl2025> Accgl2025s { get; set; }

    public virtual DbSet<Accgl2025C> Accgl2025Cs { get; set; }

    public virtual DbSet<AccglDeleted> AccglDeleteds { get; set; }

    public virtual DbSet<AccglDeletedNew> AccglDeletedNews { get; set; }

    public virtual DbSet<AccglDeletedUpdate> AccglDeletedUpdates { get; set; }

    public virtual DbSet<ActivePol2023> ActivePol2023s { get; set; }

    public virtual DbSet<ActuaryValuation> ActuaryValuations { get; set; }

    public virtual DbSet<AdjustmentLedger> AdjustmentLedgers { get; set; }

    public virtual DbSet<AdmLogin> AdmLogins { get; set; }

    public virtual DbSet<AdmRole> AdmRoles { get; set; }

    public virtual DbSet<AdmUser> AdmUsers { get; set; }

    public virtual DbSet<AdvSalTemp> AdvSalTemps { get; set; }

    public virtual DbSet<AdvacceAgainstExpName> AdvacceAgainstExpNames { get; set; }

    public virtual DbSet<AdvancePremium2021> AdvancePremium2021s { get; set; }

    public virtual DbSet<AdvancePremium2022> AdvancePremium2022s { get; set; }

    public virtual DbSet<AdvancePremium2023> AdvancePremium2023s { get; set; }

    public virtual DbSet<AdvancePremium2024> AdvancePremium2024s { get; set; }

    public virtual DbSet<AdvancePremium2025> AdvancePremium2025s { get; set; }

    public virtual DbSet<AdvanceSalaryRequest> AdvanceSalaryRequests { get; set; }

    public virtual DbSet<AdvanceSalaryRequestBkp210425> AdvanceSalaryRequestBkp210425s { get; set; }

    public virtual DbSet<AdvanceType> AdvanceTypes { get; set; }

    public virtual DbSet<AdvancedAgainstExp> AdvancedAgainstExps { get; set; }

    public virtual DbSet<AdvisorTracking> AdvisorTrackings { get; set; }

    public virtual DbSet<AgentBasicInfo> AgentBasicInfos { get; set; }

    public virtual DbSet<AgentBusinessOneYr> AgentBusinessOneYrs { get; set; }

    public virtual DbSet<AgentBusinessQtr> AgentBusinessQtrs { get; set; }

    public virtual DbSet<AgentBusinessTwoYr> AgentBusinessTwoYrs { get; set; }

    public virtual DbSet<AgentBusinessTwoYrBkp> AgentBusinessTwoYrBkps { get; set; }

    public virtual DbSet<AgentCalender> AgentCalenders { get; set; }

    public virtual DbSet<AgentComCalcDetail> AgentComCalcDetails { get; set; }

    public virtual DbSet<AgentComCalcDetailsBackUp17> AgentComCalcDetailsBackUp17s { get; set; }

    public virtual DbSet<AgentComCalcDetailsFeb55656> AgentComCalcDetailsFeb55656s { get; set; }

    public virtual DbSet<AgentComCalcDetailsPf> AgentComCalcDetailsPfs { get; set; }

    public virtual DbSet<AgentComCalcDetailsRestore> AgentComCalcDetailsRestores { get; set; }

    public virtual DbSet<AgentComPayment> AgentComPayments { get; set; }

    public virtual DbSet<AgentComRateFa> AgentComRateFas { get; set; }

    public virtual DbSet<AgentComTaxChallan> AgentComTaxChallans { get; set; }

    public virtual DbSet<AgentCommentHistory> AgentCommentHistories { get; set; }

    public virtual DbSet<AgentCommissionCalculation> AgentCommissionCalculations { get; set; }

    public virtual DbSet<AgentCommissionPr> AgentCommissionPrs { get; set; }

    public virtual DbSet<AgentContest> AgentContests { get; set; }

    public virtual DbSet<AgentContestBm> AgentContestBms { get; set; }

    public virtual DbSet<AgentDiscontinueReason> AgentDiscontinueReasons { get; set; }

    public virtual DbSet<AgentEarningPaid> AgentEarningPaids { get; set; }

    public virtual DbSet<AgentFileAllocation> AgentFileAllocations { get; set; }

    public virtual DbSet<AgentForwardingDetail> AgentForwardingDetails { get; set; }

    public virtual DbSet<AgentForwardingMaster> AgentForwardingMasters { get; set; }

    public virtual DbSet<AgentForwardingTempDetail> AgentForwardingTempDetails { get; set; }

    public virtual DbSet<AgentFullChain> AgentFullChains { get; set; }

    public virtual DbSet<AgentHierarchyList> AgentHierarchyLists { get; set; }

    public virtual DbSet<AgentIncentiveList> AgentIncentiveLists { get; set; }

    public virtual DbSet<AgentJobDetail> AgentJobDetails { get; set; }

    public virtual DbSet<AgentJobDetailsDeleted> AgentJobDetailsDeleteds { get; set; }

    public virtual DbSet<AgentLapse> AgentLapses { get; set; }

    public virtual DbSet<AgentMeeting> AgentMeetings { get; set; }

    public virtual DbSet<AgentMonthlyTarget> AgentMonthlyTargets { get; set; }

    public virtual DbSet<AgentPerfTemp1> AgentPerfTemp1s { get; set; }

    public virtual DbSet<AgentPerfTemp2Renewal> AgentPerfTemp2Renewals { get; set; }

    public virtual DbSet<AgentPerfTemp2Renewal02122025> AgentPerfTemp2Renewal02122025s { get; set; }

    public virtual DbSet<AgentPerfTemp2RenewalCopy> AgentPerfTemp2RenewalCopies { get; set; }

    public virtual DbSet<AgentPerfTemp2RenewalCurrent> AgentPerfTemp2RenewalCurrents { get; set; }

    public virtual DbSet<AgentPerformanceReport> AgentPerformanceReports { get; set; }

    public virtual DbSet<AgentPersonalLapse> AgentPersonalLapses { get; set; }

    public virtual DbSet<AgentRanking> AgentRankings { get; set; }

    public virtual DbSet<AgentSalary> AgentSalaries { get; set; }

    public virtual DbSet<AgentSalary1> AgentSalaries1 { get; set; }

    public virtual DbSet<AgentSalaryApril> AgentSalaryAprils { get; set; }

    public virtual DbSet<AgentSalaryJune> AgentSalaryJunes { get; set; }

    public virtual DbSet<AgentSalarySetup> AgentSalarySetups { get; set; }

    public virtual DbSet<AgentType> AgentTypes { get; set; }

    public virtual DbSet<AgentTypeTarget> AgentTypeTargets { get; set; }

    public virtual DbSet<AgentYearlyTarget> AgentYearlyTargets { get; set; }

    public virtual DbSet<AllAgentList> AllAgentLists { get; set; }

    public virtual DbSet<AllowableExpenseRateChart> AllowableExpenseRateCharts { get; set; }

    public virtual DbSet<AllowableExpenseRateChartHistory> AllowableExpenseRateChartHistories { get; set; }

    public virtual DbSet<AltHistoryUnlimited> AltHistoryUnlimiteds { get; set; }

    public virtual DbSet<AlterMasterPolicy> AlterMasterPolicies { get; set; }

    public virtual DbSet<AlterPayment> AlterPayments { get; set; }

    public virtual DbSet<AlterationCase> AlterationCases { get; set; }

    public virtual DbSet<AlterationHistory> AlterationHistories { get; set; }

    public virtual DbSet<AmOdoMeter> AmOdoMeters { get; set; }

    public virtual DbSet<ApiResponse> ApiResponses { get; set; }

    public virtual DbSet<ApiResponse2019> ApiResponse2019s { get; set; }

    public virtual DbSet<ApiResponse2020> ApiResponse2020s { get; set; }

    public virtual DbSet<ApiResponse2021> ApiResponse2021s { get; set; }

    public virtual DbSet<ApiResponse2022> ApiResponse2022s { get; set; }

    public virtual DbSet<ApiResponse2023> ApiResponse2023s { get; set; }

    public virtual DbSet<ApiResponse2024> ApiResponse2024s { get; set; }

    public virtual DbSet<Apiresponse2025> Apiresponse2025s { get; set; }

    public virtual DbSet<AppId> AppIds { get; set; }

    public virtual DbSet<AppNotification> AppNotifications { get; set; }

    public virtual DbSet<AppNotificationOld> AppNotificationOlds { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<ApplicantApprovalUser> ApplicantApprovalUsers { get; set; }

    public virtual DbSet<ApplicantInfo2023Del> ApplicantInfo2023Dels { get; set; }

    public virtual DbSet<ApplicationFileAllocation> ApplicationFileAllocations { get; set; }

    public virtual DbSet<AppsGrievance> AppsGrievances { get; set; }

    public virtual DbSet<AppsVersion> AppsVersions { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<AssetAssign> AssetAssigns { get; set; }

    public virtual DbSet<AssetMaintenance> AssetMaintenances { get; set; }

    public virtual DbSet<AssetMaintenancePay> AssetMaintenancePays { get; set; }

    public virtual DbSet<AssetMaster> AssetMasters { get; set; }

    public virtual DbSet<AssetName> AssetNames { get; set; }

    public virtual DbSet<AssetSale> AssetSales { get; set; }

    public virtual DbSet<AssetStock> AssetStocks { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<AssigneeInformation> AssigneeInformations { get; set; }

    public virtual DbSet<AuditClaim> AuditClaims { get; set; }

    public virtual DbSet<AuditVoucherList> AuditVoucherLists { get; set; }

    public virtual DbSet<AutoAgentCommission> AutoAgentCommissions { get; set; }

    public virtual DbSet<AutoAgentCommissionBkp> AutoAgentCommissionBkps { get; set; }

    public virtual DbSet<AutoAgentSalary> AutoAgentSalaries { get; set; }

    public virtual DbSet<BKashLiability10252023> BKashLiability10252023s { get; set; }

    public virtual DbSet<BackToPrRequest> BackToPrRequests { get; set; }

    public virtual DbSet<BankAcc> BankAccs { get; set; }

    public virtual DbSet<BankApi> BankApis { get; set; }

    public virtual DbSet<BankApi2019> BankApi2019s { get; set; }

    public virtual DbSet<BankApi2020> BankApi2020s { get; set; }

    public virtual DbSet<BankApi2021> BankApi2021s { get; set; }

    public virtual DbSet<BankApi2022> BankApi2022s { get; set; }

    public virtual DbSet<BankApi2022Old> BankApi2022Olds { get; set; }

    public virtual DbSet<BankApi2023> BankApi2023s { get; set; }

    public virtual DbSet<BankApi2024> BankApi2024s { get; set; }

    public virtual DbSet<BankApi2025> BankApi2025s { get; set; }

    public virtual DbSet<BankBranch> BankBranches { get; set; }

    public virtual DbSet<BankCustomSm> BankCustomSms { get; set; }

    public virtual DbSet<BankFlowSetting> BankFlowSettings { get; set; }

    public virtual DbSet<BankInfoUpdate> BankInfoUpdates { get; set; }

    public virtual DbSet<BankInfoUpdateUser> BankInfoUpdateUsers { get; set; }

    public virtual DbSet<BankMain> BankMains { get; set; }

    public virtual DbSet<BannerManagement> BannerManagements { get; set; }

    public virtual DbSet<BgmeaworkerList> BgmeaworkerLists { get; set; }

    public virtual DbSet<BlockSpUser> BlockSpUsers { get; set; }

    public virtual DbSet<BonusCalculation> BonusCalculations { get; set; }

    public virtual DbSet<BonusDetails16> BonusDetails16s { get; set; }

    public virtual DbSet<BonusDetails1622> BonusDetails1622s { get; set; }

    public virtual DbSet<BonusDetails16new> BonusDetails16news { get; set; }

    public virtual DbSet<BonusMaster> BonusMasters { get; set; }

    public virtual DbSet<BonusMaster22> BonusMaster22s { get; set; }

    public virtual DbSet<BonusPoliciesByYear> BonusPoliciesByYears { get; set; }

    public virtual DbSet<BonusRate> BonusRates { get; set; }

    public virtual DbSet<BonusRevDetail> BonusRevDetails { get; set; }

    public virtual DbSet<BonusRevMaster> BonusRevMasters { get; set; }

    public virtual DbSet<BonusYrlyDeathBenRate> BonusYrlyDeathBenRates { get; set; }

    public virtual DbSet<BonusYrlyMngExp> BonusYrlyMngExps { get; set; }

    public virtual DbSet<BranchLandLordInfo> BranchLandLordInfos { get; set; }

    public virtual DbSet<BranchMonthlyTarget> BranchMonthlyTargets { get; set; }

    public virtual DbSet<BranchRentUtility> BranchRentUtilities { get; set; }

    public virtual DbSet<BranchUtility> BranchUtilities { get; set; }

    public virtual DbSet<BranchYearlyTarget> BranchYearlyTargets { get; set; }

    public virtual DbSet<BudgetTbl> BudgetTbls { get; set; }

    public virtual DbSet<CallManage2021> CallManage2021s { get; set; }

    public virtual DbSet<CallManage2022> CallManage2022s { get; set; }

    public virtual DbSet<CallManage2023> CallManage2023s { get; set; }

    public virtual DbSet<CallManage2024> CallManage2024s { get; set; }

    public virtual DbSet<CallManage2025> CallManage2025s { get; set; }

    public virtual DbSet<CallManageTemp> CallManageTemps { get; set; }

    public virtual DbSet<CallUser> CallUsers { get; set; }

    public virtual DbSet<CbsilconsolidatedCustomer> CbsilconsolidatedCustomers { get; set; }

    public virtual DbSet<ChangeHistory> ChangeHistories { get; set; }

    public virtual DbSet<ChatRoom> ChatRooms { get; set; }

    public virtual DbSet<ChatRoom1> ChatRooms1 { get; set; }

    public virtual DbSet<ChatRoomGroup> ChatRoomGroups { get; set; }

    public virtual DbSet<ChatRoomGroupUser> ChatRoomGroupUsers { get; set; }

    public virtual DbSet<CheckInOut> CheckInOuts { get; set; }

    public virtual DbSet<Cic> Cics { get; set; }

    public virtual DbSet<Circular> Circulars { get; set; }

    public virtual DbSet<CircularDetail> CircularDetails { get; set; }

    public virtual DbSet<CircularMaster> CircularMasters { get; set; }

    public virtual DbSet<ClaimCourt> ClaimCourts { get; set; }

    public virtual DbSet<ClaimFileAllocation> ClaimFileAllocations { get; set; }

    public virtual DbSet<ClaimFileIn> ClaimFileIns { get; set; }

    public virtual DbSet<ClaimFileRequisition> ClaimFileRequisitions { get; set; }

    public virtual DbSet<ClaimInvestigation> ClaimInvestigations { get; set; }

    public virtual DbSet<ClaimMaster> ClaimMasters { get; set; }

    public virtual DbSet<ClaimMasterStatus> ClaimMasterStatuses { get; set; }

    public virtual DbSet<ClaimRegister> ClaimRegisters { get; set; }

    public virtual DbSet<ClaimRegisterTmp> ClaimRegisterTmps { get; set; }

    public virtual DbSet<ClaimSettlement> ClaimSettlements { get; set; }

    public virtual DbSet<ClaimSettlementFromMail> ClaimSettlementFromMails { get; set; }

    public virtual DbSet<ClaimStagePaymentList> ClaimStagePaymentLists { get; set; }

    public virtual DbSet<ClaimType> ClaimTypes { get; set; }

    public virtual DbSet<CollectionReversedNagad2023> CollectionReversedNagad2023s { get; set; }

    public virtual DbSet<ComPayTbl> ComPayTbls { get; set; }

    public virtual DbSet<ComPayTmp> ComPayTmps { get; set; }

    public virtual DbSet<ComProblem2207T5> ComProblem2207T5s { get; set; }

    public virtual DbSet<ComVatRptTbl> ComVatRptTbls { get; set; }

    public virtual DbSet<ComVatRptTbl4> ComVatRptTbl4s { get; set; }

    public virtual DbSet<CommissionRateChart> CommissionRateCharts { get; set; }

    public virtual DbSet<Compf> Compfs { get; set; }

    public virtual DbSet<Complain> Complains { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<CountMaxIdtable> CountMaxIdtables { get; set; }

    public virtual DbSet<CountryCode> CountryCodes { get; set; }

    public virtual DbSet<CourierCompanyList> CourierCompanyLists { get; set; }

    public virtual DbSet<CourierServiceSetup> CourierServiceSetups { get; set; }

    public virtual DbSet<DailyCashTransaction2021> DailyCashTransaction2021s { get; set; }

    public virtual DbSet<DailyCashTransaction2022> DailyCashTransaction2022s { get; set; }

    public virtual DbSet<DailyCashTransaction2023> DailyCashTransaction2023s { get; set; }

    public virtual DbSet<DailyCashTransaction2024> DailyCashTransaction2024s { get; set; }

    public virtual DbSet<DailyCashTransaction2025> DailyCashTransaction2025s { get; set; }

    public virtual DbSet<DailyExpense> DailyExpenses { get; set; }

    public virtual DbSet<DeathClaimOthersDocument> DeathClaimOthersDocuments { get; set; }

    public virtual DbSet<DelAccgl2022> DelAccgl2022s { get; set; }

    public virtual DbSet<DelApplicant2024> DelApplicant2024s { get; set; }

    public virtual DbSet<DeletedVoucher> DeletedVouchers { get; set; }

    public virtual DbSet<DepreDetail> DepreDetails { get; set; }

    public virtual DbSet<DepreciationDetail> DepreciationDetails { get; set; }

    public virtual DbSet<DevAdminApproval> DevAdminApprovals { get; set; }

    public virtual DbSet<Disbursement> Disbursements { get; set; }

    public virtual DbSet<Dismemberment> Dismemberments { get; set; }

    public virtual DbSet<DispatchDetail> DispatchDetails { get; set; }

    public virtual DbSet<DispatchIn> DispatchIns { get; set; }

    public virtual DbSet<DispatchOption> DispatchOptions { get; set; }

    public virtual DbSet<DispatchOut> DispatchOuts { get; set; }

    public virtual DbSet<DispatchPurpose> DispatchPurposes { get; set; }

    public virtual DbSet<DistrictList> DistrictLists { get; set; }

    public virtual DbSet<Ditclacc> Ditclaccs { get; set; }

    public virtual DbSet<DividendDetail> DividendDetails { get; set; }

    public virtual DbSet<DivisionList> DivisionLists { get; set; }

    public virtual DbSet<DocIdChangeHistory> DocIdChangeHistories { get; set; }

    public virtual DbSet<DocumentList> DocumentLists { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Dprrate> Dprrates { get; set; }

    public virtual DbSet<DpsChange> DpsChanges { get; set; }

    public virtual DbSet<DpsScheme> DpsSchemes { get; set; }

    public virtual DbSet<DpsSchemeC> DpsSchemeCs { get; set; }

    public virtual DbSet<Dpslist> Dpslists { get; set; }

    public virtual DbSet<EditPermissionUser> EditPermissionUsers { get; set; }

    public virtual DbSet<EditsAfterChairmanSir> EditsAfterChairmanSirs { get; set; }

    public virtual DbSet<Eftndetail> Eftndetails { get; set; }

    public virtual DbSet<Eftnrecord> Eftnrecords { get; set; }

    public virtual DbSet<EmpAbsent> EmpAbsents { get; set; }

    public virtual DbSet<EmpAbsentJuly2024> EmpAbsentJuly2024s { get; set; }

    public virtual DbSet<EmpAttendance> EmpAttendances { get; set; }

    public virtual DbSet<EmpBusinessPerformance> EmpBusinessPerformances { get; set; }

    public virtual DbSet<EmpChallanDetail> EmpChallanDetails { get; set; }

    public virtual DbSet<EmpDemerit> EmpDemerits { get; set; }

    public virtual DbSet<EmpDesignationHistory> EmpDesignationHistories { get; set; }

    public virtual DbSet<EmpErp> EmpErps { get; set; }

    public virtual DbSet<EmpGratuity> EmpGratuities { get; set; }

    public virtual DbSet<EmpIncrement> EmpIncrements { get; set; }

    public virtual DbSet<EmpJobDescription> EmpJobDescriptions { get; set; }

    public virtual DbSet<EmpJoiningDesignation> EmpJoiningDesignations { get; set; }

    public virtual DbSet<EmpLapse> EmpLapses { get; set; }

    public virtual DbSet<EmpMonthlyPerformance> EmpMonthlyPerformances { get; set; }

    public virtual DbSet<EmpMonthlyperformanceTemp> EmpMonthlyperformanceTemps { get; set; }

    public virtual DbSet<EmpMovementRegister> EmpMovementRegisters { get; set; }

    public virtual DbSet<EmpOt> EmpOts { get; set; }

    public virtual DbSet<EmpPayroll> EmpPayrolls { get; set; }

    public virtual DbSet<EmpRanking> EmpRankings { get; set; }

    public virtual DbSet<EmpRanking2025> EmpRanking2025s { get; set; }

    public virtual DbSet<EmpTaskDetail> EmpTaskDetails { get; set; }

    public virtual DbSet<EmpTaskEvaluation> EmpTaskEvaluations { get; set; }

    public virtual DbSet<EmployeeDocCheck> EmployeeDocChecks { get; set; }

    public virtual DbSet<EmployeeDocumentsMaster> EmployeeDocumentsMasters { get; set; }

    public virtual DbSet<ErrorChecker> ErrorCheckers { get; set; }

    public virtual DbSet<ErrorPayment> ErrorPayments { get; set; }

    public virtual DbSet<ExcludeFromReinsurance> ExcludeFromReinsurances { get; set; }

    public virtual DbSet<ExecutiveList> ExecutiveLists { get; set; }

    public virtual DbSet<ExpenditureDetail> ExpenditureDetails { get; set; }

    public virtual DbSet<ExpenditureList> ExpenditureLists { get; set; }

    public virtual DbSet<ExtraContribution> ExtraContributions { get; set; }

    public virtual DbSet<Fachange> Fachanges { get; set; }

    public virtual DbSet<FdrdateList> FdrdateLists { get; set; }

    public virtual DbSet<FileAllocAccess> FileAllocAccesses { get; set; }

    public virtual DbSet<FileAllocTemp> FileAllocTemps { get; set; }

    public virtual DbSet<FileAllocTemp2> FileAllocTemp2s { get; set; }

    public virtual DbSet<ForwardingPayDetails2021> ForwardingPayDetails2021s { get; set; }

    public virtual DbSet<ForwardingPayDetails2022> ForwardingPayDetails2022s { get; set; }

    public virtual DbSet<ForwardingPayDetails2023> ForwardingPayDetails2023s { get; set; }

    public virtual DbSet<ForwardingPayDetails2024> ForwardingPayDetails2024s { get; set; }

    public virtual DbSet<ForwardingPayDetails2025> ForwardingPayDetails2025s { get; set; }

    public virtual DbSet<Fpr> Fprs { get; set; }

    public virtual DbSet<Fpr2> Fpr2s { get; set; }

    public virtual DbSet<FprEftn> FprEftns { get; set; }

    public virtual DbSet<FprSummary> FprSummaries { get; set; }

    public virtual DbSet<FprSupplimentryDetail> FprSupplimentryDetails { get; set; }

    public virtual DbSet<Fprinserted> Fprinserteds { get; set; }

    public virtual DbSet<GiftInfo> GiftInfos { get; set; }

    public virtual DbSet<GrievanceCategory> GrievanceCategories { get; set; }

    public virtual DbSet<GrievanceManagement> GrievanceManagements { get; set; }

    public virtual DbSet<GrievanceType> GrievanceTypes { get; set; }

    public virtual DbSet<GroupAgentComPayment> GroupAgentComPayments { get; set; }

    public virtual DbSet<GroupCategory> GroupCategories { get; set; }

    public virtual DbSet<GtliMakeAclaimStatus> GtliMakeAclaimStatuses { get; set; }

    public virtual DbSet<GtliPercentFinal> GtliPercentFinals { get; set; }

    public virtual DbSet<GtliSetupStatus> GtliSetupStatuses { get; set; }

    public virtual DbSet<Gtlialteration> Gtlialterations { get; set; }

    public virtual DbSet<GtliclaimInterviewee> GtliclaimInterviewees { get; set; }

    public virtual DbSet<GtliclaimInvestigation> GtliclaimInvestigations { get; set; }

    public virtual DbSet<GtliclaimSettlement> GtliclaimSettlements { get; set; }

    public virtual DbSet<Gtlicontact> Gtlicontacts { get; set; }

    public virtual DbSet<GtliemployeeList> GtliemployeeLists { get; set; }

    public virtual DbSet<GtlimakeaClaim> GtlimakeaClaims { get; set; }

    public virtual DbSet<Gtlipayment> Gtlipayments { get; set; }

    public virtual DbSet<Gtlipercent> Gtlipercents { get; set; }

    public virtual DbSet<Gtlipremium> Gtlipremia { get; set; }

    public virtual DbSet<Gtlisetup> Gtlisetups { get; set; }

    public virtual DbSet<GtlistudentList> GtlistudentLists { get; set; }

    public virtual DbSet<Gtlisupplementary> Gtlisupplementaries { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<IdraYearEnd> IdraYearEnds { get; set; }

    public virtual DbSet<IdratotExp> IdratotExps { get; set; }

    public virtual DbSet<Iislog> Iislogs { get; set; }

    public virtual DbSet<IncomingSm> IncomingSms { get; set; }

    public virtual DbSet<Increment2024> Increment2024s { get; set; }

    public virtual DbSet<IndividualDeathClaim> IndividualDeathClaims { get; set; }

    public virtual DbSet<InvBondBuy> InvBondBuys { get; set; }

    public virtual DbSet<InvBuy> InvBuys { get; set; }

    public virtual DbSet<InvCreateInvestment> InvCreateInvestments { get; set; }

    public virtual DbSet<InvFdr> InvFdrs { get; set; }

    public virtual DbSet<InvFdrhistory> InvFdrhistories { get; set; }

    public virtual DbSet<InvLand> InvLands { get; set; }

    public virtual DbSet<InvMasterNew> InvMasterNews { get; set; }

    public virtual DbSet<InvMasterNewBrok> InvMasterNewBroks { get; set; }

    public virtual DbSet<InvProp> InvProps { get; set; }

    public virtual DbSet<InvSell> InvSells { get; set; }

    public virtual DbSet<InvShareSuspense> InvShareSuspenses { get; set; }

    public virtual DbSet<InvTempMaster> InvTempMasters { get; set; }

    public virtual DbSet<InvTypeEntry> InvTypeEntries { get; set; }

    public virtual DbSet<Invfdrc> Invfdrcs { get; set; }

    public virtual DbSet<InvfdrcDetail> InvfdrcDetails { get; set; }

    public virtual DbSet<IpphoneContact> IpphoneContacts { get; set; }

    public virtual DbSet<IssueTicket> IssueTickets { get; set; }

    public virtual DbSet<IssueTicketErp> IssueTicketErps { get; set; }

    public virtual DbSet<KycMaster> KycMasters { get; set; }

    public virtual DbSet<KycNomineeDetail> KycNomineeDetails { get; set; }

    public virtual DbSet<LapseDocApproveUser> LapseDocApproveUsers { get; set; }

    public virtual DbSet<LapseHistory> LapseHistories { get; set; }

    public virtual DbSet<LeaveManagement> LeaveManagements { get; set; }

    public virtual DbSet<LeaveSchedule> LeaveSchedules { get; set; }

    public virtual DbSet<LiabilityNovDec2022> LiabilityNovDec2022s { get; set; }

    public virtual DbSet<LoadPrimaryId> LoadPrimaryIds { get; set; }

    public virtual DbSet<LoanBondFee> LoanBondFees { get; set; }

    public virtual DbSet<LoanCardAssign> LoanCardAssigns { get; set; }

    public virtual DbSet<LoanChequeInfo> LoanChequeInfos { get; set; }

    public virtual DbSet<LoanComment> LoanComments { get; set; }

    public virtual DbSet<LoanDocument> LoanDocuments { get; set; }

    public virtual DbSet<LoanEligibilityDetail> LoanEligibilityDetails { get; set; }

    public virtual DbSet<LoanEligibilityDetailsLog> LoanEligibilityDetailsLogs { get; set; }

    public virtual DbSet<LoanEligible> LoanEligibles { get; set; }

    public virtual DbSet<LoanEligibleLog> LoanEligibleLogs { get; set; }

    public virtual DbSet<LoanManualDisburseRecquest> LoanManualDisburseRecquests { get; set; }

    public virtual DbSet<LoanMaster> LoanMasters { get; set; }

    public virtual DbSet<LoanRepay> LoanRepays { get; set; }

    public virtual DbSet<LoanRepayDelete> LoanRepayDeletes { get; set; }

    public virtual DbSet<LoanTransactionDetail> LoanTransactionDetails { get; set; }

    public virtual DbSet<LogAgentJobDetail> LogAgentJobDetails { get; set; }

    public virtual DbSet<LogPayEmpJobDetail> LogPayEmpJobDetails { get; set; }

    public virtual DbSet<LogTable> LogTables { get; set; }

    public virtual DbSet<LoginUserList> LoginUserLists { get; set; }

    public virtual DbSet<LpCardDeliveryDetail> LpCardDeliveryDetails { get; set; }

    public virtual DbSet<LpCardDetail> LpCardDetails { get; set; }

    public virtual DbSet<LpCardHolderPpdetail> LpCardHolderPpdetails { get; set; }

    public virtual DbSet<LpCardTypeDetail> LpCardTypeDetails { get; set; }

    public virtual DbSet<LpMerchantCategory> LpMerchantCategories { get; set; }

    public virtual DbSet<LpMerchantDetail> LpMerchantDetails { get; set; }

    public virtual DbSet<LpMerchantName> LpMerchantNames { get; set; }

    public virtual DbSet<MailLog> MailLogs { get; set; }

    public virtual DbSet<March23Applicant> March23Applicants { get; set; }

    public virtual DbSet<MarchComAdjustment> MarchComAdjustments { get; set; }

    public virtual DbSet<MatCheck> MatChecks { get; set; }

    public virtual DbSet<MaturityBankDetail> MaturityBankDetails { get; set; }

    public virtual DbSet<MaturityClaimProcess> MaturityClaimProcesses { get; set; }

    public virtual DbSet<MaturityClaimTemp> MaturityClaimTemps { get; set; }

    public virtual DbSet<MaturityListTable> MaturityListTables { get; set; }

    public virtual DbSet<MaturityProcessDescription> MaturityProcessDescriptions { get; set; }

    public virtual DbSet<MeetingSchedule> MeetingSchedules { get; set; }

    public virtual DbSet<MetroSamdlist> MetroSamdlists { get; set; }

    public virtual DbSet<MisscallLog> MisscallLogs { get; set; }

    public virtual DbSet<MissingDeathClaim> MissingDeathClaims { get; set; }

    public virtual DbSet<MissingSupplementaryClaim> MissingSupplementaryClaims { get; set; }

    public virtual DbSet<MobileEmailChange> MobileEmailChanges { get; set; }

    public virtual DbSet<ModeControl> ModeControls { get; set; }

    public virtual DbSet<ModeControl1> ModeControl1s { get; set; }

    public virtual DbSet<ModePerfSchedule> ModePerfSchedules { get; set; }

    public virtual DbSet<MonthWiseCommission> MonthWiseCommissions { get; set; }

    public virtual DbSet<MonthlyCommission> MonthlyCommissions { get; set; }

    public virtual DbSet<MonthlyPf> MonthlyPfs { get; set; }

    public virtual DbSet<MotorExpense> MotorExpenses { get; set; }

    public virtual DbSet<MotorRegistration> MotorRegistrations { get; set; }

    public virtual DbSet<MrbaeditedRecord> MrbaeditedRecords { get; set; }

    public virtual DbSet<NagadMerchantQueue> NagadMerchantQueues { get; set; }

    public virtual DbSet<NomineeAlteration> NomineeAlterations { get; set; }

    public virtual DbSet<NoticeBoardSetup> NoticeBoardSetups { get; set; }

    public virtual DbSet<NoticeParticipant> NoticeParticipants { get; set; }

    public virtual DbSet<OnlinePaymentLog> OnlinePaymentLogs { get; set; }

    public virtual DbSet<OnlinePaymentLog2019> OnlinePaymentLog2019s { get; set; }

    public virtual DbSet<OnlinePaymentLog2020> OnlinePaymentLog2020s { get; set; }

    public virtual DbSet<OnlinePaymentLog2021> OnlinePaymentLog2021s { get; set; }

    public virtual DbSet<OnlinePaymentLog2022> OnlinePaymentLog2022s { get; set; }

    public virtual DbSet<OnlinePaymentLog2023> OnlinePaymentLog2023s { get; set; }

    public virtual DbSet<OnlinePaymentLog2024> OnlinePaymentLog2024s { get; set; }

    public virtual DbSet<OnlinePaymentLog2025> OnlinePaymentLog2025s { get; set; }

    public virtual DbSet<OnlineUser> OnlineUsers { get; set; }

    public virtual DbSet<OrDue> OrDues { get; set; }

    public virtual DbSet<OrFirstYrSummary> OrFirstYrSummaries { get; set; }

    public virtual DbSet<OrRenewalSummary> OrRenewalSummaries { get; set; }

    public virtual DbSet<Ormaster> Ormasters { get; set; }

    public virtual DbSet<OrmultiEntry> OrmultiEntries { get; set; }

    public virtual DbSet<Outstanding2021> Outstanding2021s { get; set; }

    public virtual DbSet<Outstanding2022> Outstanding2022s { get; set; }

    public virtual DbSet<OutstandingLapse2021> OutstandingLapse2021s { get; set; }

    public virtual DbSet<OutstandingLapse2022> OutstandingLapse2022s { get; set; }

    public virtual DbSet<OverCommissionPaid03222025> OverCommissionPaid03222025s { get; set; }

    public virtual DbSet<OverCommissionPaid03222025Updated> OverCommissionPaid03222025Updateds { get; set; }

    public virtual DbSet<OverCommissionPaidReconcile04122025> OverCommissionPaidReconcile04122025s { get; set; }

    public virtual DbSet<PayCompProfileInfo> PayCompProfileInfoes { get; set; }

    public virtual DbSet<PayDepartment> PayDepartments { get; set; }

    public virtual DbSet<PayDesignation> PayDesignations { get; set; }

    public virtual DbSet<PayEmployeeJobDetail> PayEmployeeJobDetails { get; set; }

    public virtual DbSet<PayEmployeeJobDetails20012024> PayEmployeeJobDetails20012024s { get; set; }

    public virtual DbSet<PayEmployeesBasicInfo> PayEmployeesBasicInfoes { get; set; }

    public virtual DbSet<PayEmployeesBasicInfoes1> PayEmployeesBasicInfoes1s { get; set; }

    public virtual DbSet<PayEmployeesBasicInfoes20012024> PayEmployeesBasicInfoes20012024s { get; set; }

    public virtual DbSet<PayEmployeesBranch> PayEmployeesBranches { get; set; }

    public virtual DbSet<PayPageObject> PayPageObjects { get; set; }

    public virtual DbSet<PayPageObjectRole> PayPageObjectRoles { get; set; }

    public virtual DbSet<PayRole> PayRoles { get; set; }

    public virtual DbSet<PayScale> PayScales { get; set; }

    public virtual DbSet<PaymentApi2020> PaymentApi2020s { get; set; }

    public virtual DbSet<PaymentApi2021> PaymentApi2021s { get; set; }

    public virtual DbSet<PaymentApi2022> PaymentApi2022s { get; set; }

    public virtual DbSet<PaymentApi2022Old> PaymentApi2022Olds { get; set; }

    public virtual DbSet<PaymentApi2023> PaymentApi2023s { get; set; }

    public virtual DbSet<PaymentApi2024> PaymentApi2024s { get; set; }

    public virtual DbSet<PaymentApi2025> PaymentApi2025s { get; set; }

    public virtual DbSet<PaymentApi2025Dup> PaymentApi2025Dups { get; set; }

    public virtual DbSet<PaymentLog> PaymentLogs { get; set; }

    public virtual DbSet<PaymentLog2019> PaymentLog2019s { get; set; }

    public virtual DbSet<PaymentLog2020> PaymentLog2020s { get; set; }

    public virtual DbSet<PaymentLog2021> PaymentLog2021s { get; set; }

    public virtual DbSet<PaymentLog2022> PaymentLog2022s { get; set; }

    public virtual DbSet<PaymentLog2023> PaymentLog2023s { get; set; }

    public virtual DbSet<PaymentLog2024> PaymentLog2024s { get; set; }

    public virtual DbSet<PaymentLog2025> PaymentLog2025s { get; set; }

    public virtual DbSet<Pdab> Pdabs { get; set; }

    public virtual DbSet<PensionScheme> PensionSchemes { get; set; }

    public virtual DbSet<PensionSchemeDetailsAgent> PensionSchemeDetailsAgents { get; set; }

    public virtual DbSet<PensionSchemeDetailsAgents07272022> PensionSchemeDetailsAgents07272022s { get; set; }

    public virtual DbSet<PensionSchemeDetailsAgentsBackUp> PensionSchemeDetailsAgentsBackUps { get; set; }

    public virtual DbSet<PensionSchemeMasterAgent> PensionSchemeMasterAgents { get; set; }

    public virtual DbSet<PensionSchemeMasterAgents07272022> PensionSchemeMasterAgents07272022s { get; set; }

    public virtual DbSet<PfSerial6> PfSerial6s { get; set; }

    public virtual DbSet<Pfcompany> Pfcompanies { get; set; }

    public virtual DbSet<Policy10SvpaidUpRate> Policy10SvpaidUpRates { get; set; }

    public virtual DbSet<PolicyAdvisor> PolicyAdvisors { get; set; }

    public virtual DbSet<PolicyApplicantNominee> PolicyApplicantNominees { get; set; }

    public virtual DbSet<PolicyApplicantsFamilyHistory> PolicyApplicantsFamilyHistories { get; set; }

    public virtual DbSet<PolicyApplicantsPersonalInfo> PolicyApplicantsPersonalInfos { get; set; }

    public virtual DbSet<PolicyApplicantsPolicyInfo> PolicyApplicantsPolicyInfos { get; set; }

    public virtual DbSet<PolicyCategory> PolicyCategories { get; set; }

    public virtual DbSet<PolicyDetail> PolicyDetails { get; set; }

    public virtual DbSet<PolicyDetailsFeb55656> PolicyDetailsFeb55656s { get; set; }

    public virtual DbSet<PolicyDetailsRestore> PolicyDetailsRestores { get; set; }

    public virtual DbSet<PolicyDoctorSecretInfo> PolicyDoctorSecretInfos { get; set; }

    public virtual DbSet<PolicyEntryStatus> PolicyEntryStatuses { get; set; }

    public virtual DbSet<PolicyFpr> PolicyFprs { get; set; }

    public virtual DbSet<PolicyHolderContest> PolicyHolderContests { get; set; }

    public virtual DbSet<PolicyHolderContestTemp> PolicyHolderContestTemps { get; set; }

    public virtual DbSet<PolicyHolderContestWinner> PolicyHolderContestWinners { get; set; }

    public virtual DbSet<PolicyHolderTaxChallan> PolicyHolderTaxChallans { get; set; }

    public virtual DbSet<PolicyInfo> PolicyInfos { get; set; }

    public virtual DbSet<PolicyInstallmentType> PolicyInstallmentTypes { get; set; }

    public virtual DbSet<PolicyInsurancePlan> PolicyInsurancePlans { get; set; }

    public virtual DbSet<PolicyMedicalExamReport> PolicyMedicalExamReports { get; set; }

    public virtual DbSet<PolicyMr> PolicyMrs { get; set; }

    public virtual DbSet<PolicyPremiumReceipt> PolicyPremiumReceipts { get; set; }

    public virtual DbSet<PolicyPremiumReceiptNew> PolicyPremiumReceiptNews { get; set; }

    public virtual DbSet<PolicyProvisionalReceipt> PolicyProvisionalReceipts { get; set; }

    public virtual DbSet<PolicyStampCategory> PolicyStampCategories { get; set; }

    public virtual DbSet<PolicyStampIn> PolicyStampIns { get; set; }

    public virtual DbSet<PolicyStampInventory> PolicyStampInventories { get; set; }

    public virtual DbSet<PolicyStampRequisition> PolicyStampRequisitions { get; set; }

    public virtual DbSet<PolicyStampUsage> PolicyStampUsages { get; set; }

    public virtual DbSet<PolicyStatusCheck> PolicyStatusChecks { get; set; }

    public virtual DbSet<PolicySupplementry> PolicySupplementries { get; set; }

    public virtual DbSet<PolicySupplimentryEntry> PolicySupplimentryEntries { get; set; }

    public virtual DbSet<PolicySurrenderValue> PolicySurrenderValues { get; set; }

    public virtual DbSet<PolicyToDeed> PolicyToDeeds { get; set; }

    public virtual DbSet<PolicyToDeedStatus> PolicyToDeedStatuses { get; set; }

    public virtual DbSet<PopUpDoc> PopUpDocs { get; set; }

    public virtual DbSet<PorichoyDatum> PorichoyData { get; set; }

    public virtual DbSet<PrDetail> PrDetails { get; set; }

    public virtual DbSet<PrDetailsFeb55656> PrDetailsFeb55656s { get; set; }

    public virtual DbSet<PrSummary> PrSummaries { get; set; }

    public virtual DbSet<PremiumIncomeRpt> PremiumIncomeRpts { get; set; }

    public virtual DbSet<PrivilegeCardAgent> PrivilegeCardAgents { get; set; }

    public virtual DbSet<PrivilegeCardPolicyHolder> PrivilegeCardPolicyHolders { get; set; }

    public virtual DbSet<ProcedureLog> ProcedureLogs { get; set; }

    public virtual DbSet<ProcessWithCode> ProcessWithCodes { get; set; }

    public virtual DbSet<ProcessWithCodesMonthWise> ProcessWithCodesMonthWises { get; set; }

    public virtual DbSet<ProcurementCategory> ProcurementCategories { get; set; }

    public virtual DbSet<ProcurementCommittee> ProcurementCommittees { get; set; }

    public virtual DbSet<ProcurementDetail> ProcurementDetails { get; set; }

    public virtual DbSet<ProcurementMaster> ProcurementMasters { get; set; }

    public virtual DbSet<ProcurementQuotation> ProcurementQuotations { get; set; }

    public virtual DbSet<ProfitInforce> ProfitInforces { get; set; }

    public virtual DbSet<Psdelivery> Psdeliveries { get; set; }

    public virtual DbSet<PurchasePriceQuotation> PurchasePriceQuotations { get; set; }

    public virtual DbSet<PurchaseProductReceive> PurchaseProductReceives { get; set; }

    public virtual DbSet<PurchaseReqisition> PurchaseReqisitions { get; set; }

    public virtual DbSet<PushPullLog> PushPullLogs { get; set; }

    public virtual DbSet<QuAlterIssue> QuAlterIssues { get; set; }

    public virtual DbSet<QuConfigTab> QuConfigTabs { get; set; }

    public virtual DbSet<QuSetup> QuSetups { get; set; }

    public virtual DbSet<QuSetupBkp> QuSetupBkps { get; set; }

    public virtual DbSet<QueryCategory> QueryCategories { get; set; }

    public virtual DbSet<RankingFrenquency> RankingFrenquencies { get; set; }

    public virtual DbSet<RankingPrOr> RankingPrOrs { get; set; }

    public virtual DbSet<RawtblAgent> RawtblAgents { get; set; }

    public virtual DbSet<RawtblAgentTeam> RawtblAgentTeams { get; set; }

    public virtual DbSet<ReInsuranceCalculation> ReInsuranceCalculations { get; set; }

    public virtual DbSet<ReInsuranceCalculation1> ReInsuranceCalculation1s { get; set; }

    public virtual DbSet<ReInsuranceCalculationTest> ReInsuranceCalculationTests { get; set; }

    public virtual DbSet<ReInsuranceDeletedLog> ReInsuranceDeletedLogs { get; set; }

    public virtual DbSet<ReadRfid> ReadRfids { get; set; }

    public virtual DbSet<RecAssetStock> RecAssetStocks { get; set; }

    public virtual DbSet<RecExpense> RecExpenses { get; set; }

    public virtual DbSet<RecievableList> RecievableLists { get; set; }

    public virtual DbSet<RecurringJournal> RecurringJournals { get; set; }

    public virtual DbSet<RecurringJournalC> RecurringJournalCs { get; set; }

    public virtual DbSet<RecurringSchedule> RecurringSchedules { get; set; }

    public virtual DbSet<RecurringScheduleC> RecurringScheduleCs { get; set; }

    public virtual DbSet<Reinsurance> Reinsurances { get; set; }

    public virtual DbSet<ReinsuranceDetail> ReinsuranceDetails { get; set; }

    public virtual DbSet<ReinsuranceDetailsAlt> ReinsuranceDetailsAlts { get; set; }

    public virtual DbSet<ReinsuranceDetailsAltBkp12052024> ReinsuranceDetailsAltBkp12052024s { get; set; }

    public virtual DbSet<ReinsuranceDetailsBkp12052024> ReinsuranceDetailsBkp12052024s { get; set; }

    public virtual DbSet<ReinsuranceDetailsTable> ReinsuranceDetailsTables { get; set; }

    public virtual DbSet<ReinsuranceExtraPremium> ReinsuranceExtraPremia { get; set; }

    public virtual DbSet<ReinsurancePaymentCheck> ReinsurancePaymentChecks { get; set; }

    public virtual DbSet<ReinsurancePremiumRate> ReinsurancePremiumRates { get; set; }

    public virtual DbSet<ReinsuranceProcess> ReinsuranceProcesses { get; set; }

    public virtual DbSet<ReinsuranceRegister> ReinsuranceRegisters { get; set; }

    public virtual DbSet<ReinsuranceRegisterDetail> ReinsuranceRegisterDetails { get; set; }

    public virtual DbSet<ReinsuranceSummary> ReinsuranceSummaries { get; set; }

    public virtual DbSet<ReinsuranceSupplementaryRate> ReinsuranceSupplementaryRates { get; set; }

    public virtual DbSet<ReinsuranceSupplementaryRateBkp> ReinsuranceSupplementaryRateBkps { get; set; }

    public virtual DbSet<ReinsurencePerPolicy> ReinsurencePerPolicies { get; set; }

    public virtual DbSet<RenewalPercentage> RenewalPercentages { get; set; }

    public virtual DbSet<RequisitionAudit> RequisitionAudits { get; set; }

    public virtual DbSet<ResumeCollection> ResumeCollections { get; set; }

    public virtual DbSet<RfDailyAttendance> RfDailyAttendances { get; set; }

    public virtual DbSet<RfTempDailyAttendance> RfTempDailyAttendances { get; set; }

    public virtual DbSet<RfidReader> RfidReaders { get; set; }

    public virtual DbSet<RptAgentOr> RptAgentOrs { get; set; }

    public virtual DbSet<RptExpectedRenewal> RptExpectedRenewals { get; set; }

    public virtual DbSet<RptLapseSamd> RptLapseSamds { get; set; }

    public virtual DbSet<SalaryAdjust2025> SalaryAdjust2025s { get; set; }

    public virtual DbSet<SalaryCalculation> SalaryCalculations { get; set; }

    public virtual DbSet<SbclaimPaid2022> SbclaimPaid2022s { get; set; }

    public virtual DbSet<SessionLoginHistory> SessionLoginHistories { get; set; }

    public virtual DbSet<SetNotification> SetNotifications { get; set; }

    public virtual DbSet<ShareDetail> ShareDetails { get; set; }

    public virtual DbSet<ShareHolderEntry> ShareHolderEntries { get; set; }

    public virtual DbSet<ShareHolderName> ShareHolderNames { get; set; }

    public virtual DbSet<ShareHolderType> ShareHolderTypes { get; set; }

    public virtual DbSet<ShareTransfer> ShareTransfers { get; set; }

    public virtual DbSet<Smrneeded> Smrneededs { get; set; }

    public virtual DbSet<Smrupdate> Smrupdates { get; set; }

    public virtual DbSet<SmsLog> SmsLogs { get; set; }

    public virtual DbSet<SmsLogJune> SmsLogJunes { get; set; }

    public virtual DbSet<SmsPurpose> SmsPurposes { get; set; }

    public virtual DbSet<SpecialPermissionAgent> SpecialPermissionAgents { get; set; }

    public virtual DbSet<SqlQuery052020> SqlQuery052020s { get; set; }

    public virtual DbSet<Sqlmapoutput> Sqlmapoutputs { get; set; }

    public virtual DbSet<SslSm> SslSms { get; set; }

    public virtual DbSet<StatementOfKeyFinancialIndicato> StatementOfKeyFinancialIndicatos { get; set; }

    public virtual DbSet<StipendBankDetail> StipendBankDetails { get; set; }

    public virtual DbSet<StoreCategory> StoreCategories { get; set; }

    public virtual DbSet<StoreItem> StoreItems { get; set; }

    public virtual DbSet<StoreItemsIn> StoreItemsIns { get; set; }

    public virtual DbSet<StoreItemsOut> StoreItemsOuts { get; set; }

    public virtual DbSet<StoreMaster> StoreMasters { get; set; }

    public virtual DbSet<StorePurchaseRec> StorePurchaseRecs { get; set; }

    public virtual DbSet<SubGroupCategory> SubGroupCategories { get; set; }

    public virtual DbSet<SupplementaryClaimApplication> SupplementaryClaimApplications { get; set; }

    public virtual DbSet<SupplimentryCombination> SupplimentryCombinations { get; set; }

    public virtual DbSet<SurrenderAnalytic> SurrenderAnalytics { get; set; }

    public virtual DbSet<SurveillanceCamara> SurveillanceCamaras { get; set; }

    public virtual DbSet<Tbl1> Tbl1s { get; set; }

    public virtual DbSet<Tbl2> Tbl2s { get; set; }

    public virtual DbSet<TblChart> TblCharts { get; set; }

    public virtual DbSet<TblFpr> TblFprs { get; set; }

    public virtual DbSet<TeamDeed> TeamDeeds { get; set; }

    public virtual DbSet<TeamLeaderClaim> TeamLeaderClaims { get; set; }

    public virtual DbSet<TeamLeaderEntry> TeamLeaderEntries { get; set; }

    public virtual DbSet<TeamMemberClaim> TeamMemberClaims { get; set; }

    public virtual DbSet<TempAgentSalary> TempAgentSalaries { get; set; }

    public virtual DbSet<TempApplicantFamilyHistoryTbl> TempApplicantFamilyHistoryTbls { get; set; }

    public virtual DbSet<TempApplicantNomineeTbl> TempApplicantNomineeTbls { get; set; }

    public virtual DbSet<TempDailyExpense> TempDailyExpenses { get; set; }

    public virtual DbSet<TempPolicyToDeed> TempPolicyToDeeds { get; set; }

    public virtual DbSet<Tempagent> Tempagents { get; set; }

    public virtual DbSet<Test2> Test2s { get; set; }

    public virtual DbSet<TestAgentComCalcDetail> TestAgentComCalcDetails { get; set; }

    public virtual DbSet<TestAgentPerf> TestAgentPerves { get; set; }

    public virtual DbSet<TestAgentperfad> TestAgentperfads { get; set; }

    public virtual DbSet<TestChartRate> TestChartRates { get; set; }

    public virtual DbSet<TestDataInsertUpdateDelete> TestDataInsertUpdateDeletes { get; set; }

    public virtual DbSet<TestOnlinePay> TestOnlinePays { get; set; }

    public virtual DbSet<TestQueue> TestQueues { get; set; }

    public virtual DbSet<Testz> Testzs { get; set; }

    public virtual DbSet<ThanaList> ThanaLists { get; set; }

    public virtual DbSet<Tinserted> Tinserteds { get; set; }

    public virtual DbSet<TitasAgentTemp> TitasAgentTemps { get; set; }

    public virtual DbSet<TmpAcc2> TmpAcc2s { get; set; }

    public virtual DbSet<TmpAccChart> TmpAccCharts { get; set; }

    public virtual DbSet<TmpAccGlUmp> TmpAccGlUmps { get; set; }

    public virtual DbSet<TmpAgentForwardingError> TmpAgentForwardingErrors { get; set; }

    public virtual DbSet<TmpBipulTest> TmpBipulTests { get; set; }

    public virtual DbSet<TmpBkash> TmpBkashes { get; set; }

    public virtual DbSet<TmpBkash1> TmpBkash1s { get; set; }

    public virtual DbSet<TmpBkash10> TmpBkash10s { get; set; }

    public virtual DbSet<TmpBkash2024> TmpBkash2024s { get; set; }

    public virtual DbSet<TmpBkashBk> TmpBkashBks { get; set; }

    public virtual DbSet<TmpBkashDelete> TmpBkashDeletes { get; set; }

    public virtual DbSet<TmpBkashError> TmpBkashErrors { get; set; }

    public virtual DbSet<TmpClaimApi> TmpClaimApis { get; set; }

    public virtual DbSet<TmpDeath> TmpDeaths { get; set; }

    public virtual DbSet<TmpIislog> TmpIislogs { get; set; }

    public virtual DbSet<TmpInvalidClaimDatum> TmpInvalidClaimData { get; set; }

    public virtual DbSet<TmpPolicy> TmpPolicies { get; set; }

    public virtual DbSet<TmpPolicyApplicantNominee> TmpPolicyApplicantNominees { get; set; }

    public virtual DbSet<TmpPolicyApplicantsFamilyHistory> TmpPolicyApplicantsFamilyHistories { get; set; }

    public virtual DbSet<TmpPolicyApplicantsPersonalInfo> TmpPolicyApplicantsPersonalInfos { get; set; }

    public virtual DbSet<TmpPolicyApplicantsPolicyInfo> TmpPolicyApplicantsPolicyInfos { get; set; }

    public virtual DbSet<TmpPolicyFix> TmpPolicyFixes { get; set; }

    public virtual DbSet<TmpReversionary> TmpReversionaries { get; set; }

    public virtual DbSet<TmpTransactionList> TmpTransactionLists { get; set; }

    public virtual DbSet<TmpUmpClaimApiStatusHealth> TmpUmpClaimApiStatusHealths { get; set; }

    public virtual DbSet<TmpUmpclaimApi> TmpUmpclaimApis { get; set; }

    public virtual DbSet<TmpUmpclaimErr> TmpUmpclaimErrs { get; set; }

    public virtual DbSet<TmpUmpclaimError> TmpUmpclaimErrors { get; set; }

    public virtual DbSet<TmpUmpdatum> TmpUmpdata { get; set; }

    public virtual DbSet<TmpUmpinvalidPolicy> TmpUmpinvalidPolicies { get; set; }

    public virtual DbSet<TmpUmppolicyError> TmpUmppolicyErrors { get; set; }

    public virtual DbSet<TourBudget> TourBudgets { get; set; }

    public virtual DbSet<TourPlan> TourPlans { get; set; }

    public virtual DbSet<TrailUse> TrailUses { get; set; }

    public virtual DbSet<TrainingSchedule> TrainingSchedules { get; set; }

    public virtual DbSet<Tran> Trans { get; set; }

    public virtual DbSet<Traning> Tranings { get; set; }

    public virtual DbSet<TraningQuestion> TraningQuestions { get; set; }

    public virtual DbSet<TransactionCheck> TransactionChecks { get; set; }

    public virtual DbSet<TransferHistory> TransferHistories { get; set; }

    public virtual DbSet<Trash> Trashes { get; set; }

    public virtual DbSet<TrialBalByUser> TrialBalByUsers { get; set; }

    public virtual DbSet<TrialBalSubGroup> TrialBalSubGroups { get; set; }

    public virtual DbSet<TrnDelete072223> TrnDelete072223s { get; set; }

    public virtual DbSet<TrnDelete072223V2> TrnDelete072223V2s { get; set; }

    public virtual DbSet<UmpAllMismatch10252023> UmpAllMismatch10252023s { get; set; }

    public virtual DbSet<UmpClaimApiStatus> UmpClaimApiStatuses { get; set; }

    public virtual DbSet<UmpModifiedDatum> UmpModifiedData { get; set; }

    public virtual DbSet<UmrahTour2023> UmrahTour2023s { get; set; }

    public virtual DbSet<UnionList> UnionLists { get; set; }

    public virtual DbSet<UpDocLapse> UpDocLapses { get; set; }

    public virtual DbSet<UpdateAgentComCalcDetail> UpdateAgentComCalcDetails { get; set; }

    public virtual DbSet<UpdateDeleteHistory> UpdateDeleteHistories { get; set; }

    public virtual DbSet<UpdateDeleteType> UpdateDeleteTypes { get; set; }

    public virtual DbSet<UpdatedPendingRequestPolicy05302024> UpdatedPendingRequestPolicy05302024s { get; set; }

    public virtual DbSet<UploadFile> UploadFiles { get; set; }

    public virtual DbSet<UserCashLimit> UserCashLimits { get; set; }

    public virtual DbSet<UserFromOnline> UserFromOnlines { get; set; }

    public virtual DbSet<UserHistory> UserHistories { get; set; }

    public virtual DbSet<UserLog> UserLogs { get; set; }

    public virtual DbSet<UserTask> UserTasks { get; set; }

    public virtual DbSet<UserTaskOld> UserTaskOlds { get; set; }

    public virtual DbSet<UserTempLog> UserTempLogs { get; set; }

    public virtual DbSet<VacancyList> VacancyLists { get; set; }

    public virtual DbSet<VehicleEmiPayment> VehicleEmiPayments { get; set; }

    public virtual DbSet<VehicleMaintenance> VehicleMaintenances { get; set; }

    public virtual DbSet<VehicleOnEmi> VehicleOnEmis { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<VendorCategory> VendorCategories { get; set; }

    public virtual DbSet<VendorEnlistmentList> VendorEnlistmentLists { get; set; }

    public virtual DbSet<VendorItem> VendorItems { get; set; }

    public virtual DbSet<VirtualAgentAnswer> VirtualAgentAnswers { get; set; }

    public virtual DbSet<VirtualAgentQuestion> VirtualAgentQuestions { get; set; }

    public virtual DbSet<VisitorCount> VisitorCounts { get; set; }

    public virtual DbSet<VisitorLog> VisitorLogs { get; set; }

    public virtual DbSet<VwAllowableExpenseRateChart> VwAllowableExpenseRateCharts { get; set; }

    public virtual DbSet<WebApplicant> WebApplicants { get; set; }

    public virtual DbSet<WebApplicantBackup> WebApplicantBackups { get; set; }

    public virtual DbSet<WebApplicantFamilyHistory> WebApplicantFamilyHistories { get; set; }

    public virtual DbSet<WebApplicantPolicyInfo> WebApplicantPolicyInfos { get; set; }

    public virtual DbSet<WebCorporateSpeech> WebCorporateSpeeches { get; set; }

    public virtual DbSet<WebDirectorsSpeech> WebDirectorsSpeeches { get; set; }

    public virtual DbSet<WebDptEmployee> WebDptEmployees { get; set; }

    public virtual DbSet<WebFaq> WebFaqs { get; set; }

    public virtual DbSet<WebFinancialStatement> WebFinancialStatements { get; set; }

    public virtual DbSet<WebFormDownload> WebFormDownloads { get; set; }

    public virtual DbSet<WebGroupPass> WebGroupPasses { get; set; }

    public virtual DbSet<WebLeaveUsMessage> WebLeaveUsMessages { get; set; }

    public virtual DbSet<WebMsg> WebMsgs { get; set; }

    public virtual DbSet<WebNominee> WebNominees { get; set; }

    public virtual DbSet<WebPartner> WebPartners { get; set; }

    public virtual DbSet<WebPaymentHistry> WebPaymentHistries { get; set; }

    public virtual DbSet<WebProduct> WebProducts { get; set; }

    public virtual DbSet<WebQuoteTable> WebQuoteTables { get; set; }

    public virtual DbSet<WebShariahBoardSpeech> WebShariahBoardSpeeches { get; set; }

    public virtual DbSet<WebTermsCondition> WebTermsConditions { get; set; }

    public virtual DbSet<WebUserInfo> WebUserInfos { get; set; }

    public virtual DbSet<WebsiteDatum> WebsiteData { get; set; }

    public virtual DbSet<WebsiteNoticeEvent> WebsiteNoticeEvents { get; set; }

    public virtual DbSet<WrongEntry> WrongEntries { get; set; }

    public virtual DbSet<Xyz> Xyzs { get; set; }

    public virtual DbSet<YourTableName> YourTableNames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=172.17.20.104;Database=LogicalTestDB;User Id=seTutul;Password=yK829>ug;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AaccAdjust21>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AaccAdjust21");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Fprid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fprid");
            entity.Property(e => e.OrentryId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.St)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("st");
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
        });

        modelBuilder.Entity<AaccAdjust21Pr>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AaccAdjust21PR");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Fprid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fprid");
            entity.Property(e => e.OrentryId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.St)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("st");
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
        });

        modelBuilder.Entity<AboutU>(entity =>
        {
            entity.Property(e => e.AboutDesc).IsUnicode(false);
            entity.Property(e => e.AboutImg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AboutTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccBankCheque>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AccNo).HasMaxLength(50);
            entity.Property(e => e.BookNo).HasMaxLength(50);
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.ChequeStatus).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccBankPayForwarding>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AccBankPayForwarding", tb => tb.HasTrigger("TR_AccBankPayForwarding_Insert_UMP_API_JSON"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName).IsUnicode(false);
            entity.Property(e => e.BatchNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClaimId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerAccNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DisburseDate).HasColumnType("datetime");
            entity.Property(e => e.EmailVoucherNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PayAmount).HasColumnType("money");
            entity.Property(e => e.Remarks)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.RoutingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SliBankName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SliaccNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SLIAccNo");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("NotProcessed");
            entity.Property(e => e.TxnTyp)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccBasic>(entity =>
        {
            entity.ToTable("AccBasic");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bonus)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Rpt)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<AccCashTemp>(entity =>
        {
            entity.ToTable("AccCashTemp");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Damount).HasColumnName("DAmount");
            entity.Property(e => e.FromActCode).HasMaxLength(50);
        });

        modelBuilder.Entity<AccCfsetting>(entity =>
        {
            entity.ToTable("AccCFSetting");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasMaxLength(50);
        });

        modelBuilder.Entity<AccChart>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccChart");

            entity.HasIndex(e => e.ActCode, "ActCode_AccChart").HasFillFactor(90);

            entity.HasIndex(e => e.AccLevel, "ActLevel_AccChart");

            entity.HasIndex(e => e.AccLevel, "indx_AccChart_AccLevel");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AccLevel).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasColumnType("numeric(30, 0)");
            entity.Property(e => e.ActName).HasMaxLength(500);
            entity.Property(e => e.Brokerage)
                .HasMaxLength(10)
                .HasDefaultValue("n")
                .IsFixedLength();
            entity.Property(e => e.Cl).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Ex)
                .HasMaxLength(50)
                .HasDefaultValue("y");
            entity.Property(e => e.Inserted)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.IsGroup)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasDefaultValue("NotAdmin");
        });

        modelBuilder.Entity<AccChartC>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccChartC");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AccLevel).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasColumnType("numeric(30, 0)");
            entity.Property(e => e.ActName).HasMaxLength(100);
            entity.Property(e => e.Brokerage)
                .HasMaxLength(10)
                .HasDefaultValue("n")
                .IsFixedLength();
            entity.Property(e => e.Cl).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Inserted)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.IsGroup)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<AccChartDetail>(entity =>
        {
            entity.ToTable("AccChartDetail");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasColumnType("numeric(30, 0)");
            entity.Property(e => e.ActName).HasMaxLength(500);
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasDefaultValue("NotAdmin");
        });

        modelBuilder.Entity<AccChartDetailAppAgent>(entity =>
        {
            entity.ToTable("AccChartDetailAppAgent");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasColumnType("numeric(30, 0)");
            entity.Property(e => e.ActName).HasMaxLength(500);
            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasDefaultValue("NotAdmin");
        });

        modelBuilder.Entity<AccClosingTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AccClosingTbl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActName)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Actcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccDetailTransaction>(entity =>
        {
            entity.ToTable("AccDetailTransaction");

            entity.Property(e => e.ActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActName).IsUnicode(false);
            entity.Property(e => e.AgentId).HasMaxLength(50);
            entity.Property(e => e.AgentType).HasMaxLength(50);
            entity.Property(e => e.Branch).IsUnicode(false);
            entity.Property(e => e.Chq).HasMaxLength(100);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccExpense>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.Property(e => e.Sl)
                .ValueGeneratedNever()
                .HasColumnName("SL");
            entity.Property(e => e.HeadId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeadName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HeadType)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccGl2012>(entity =>
        {
            entity.ToTable("AccGl2012");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasColumnType("numeric(32, 0)");
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.New)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2013>(entity =>
        {
            entity.ToTable("AccGl2013", tb =>
                {
                    tb.HasTrigger("trg_DELETEC13");
                    tb.HasTrigger("trg_UpdateC13");
                    tb.HasTrigger("trg_UpdateNextInterestDueDate13");
                });

            entity.HasIndex(e => e.FromActCode, "FromAct_AccGl2013");

            entity.HasIndex(e => e.VoucherNo, "Vno_AccGl2013");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasColumnType("numeric(32, 0)");
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2013C>(entity =>
        {
            entity.ToTable("AccGl2013C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasColumnType("numeric(32, 0)");
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2014>(entity =>
        {
            entity.ToTable("AccGl2014");

            entity.HasIndex(e => e.FromActCode, "ActCode_AccGl2014");

            entity.HasIndex(e => e.VoucherNo, "Vno_AccGl2014");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2014C>(entity =>
        {
            entity.ToTable("AccGl2014C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2015>(entity =>
        {
            entity.ToTable("AccGl2015");

            entity.HasIndex(e => e.FromActCode, "ActcODE_AccGl2015_1");

            entity.HasIndex(e => e.EntryDate, "IX_AccGl2015").IsDescending();

            entity.HasIndex(e => e.VoucherNo, "Vno_AccGl2015_1");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2015C>(entity =>
        {
            entity.ToTable("AccGl2015C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2016>(entity =>
        {
            entity.ToTable("AccGl2016");

            entity.HasIndex(e => e.ActCode, "IX_AccGl2016");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2016C>(entity =>
        {
            entity.ToTable("AccGl2016C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2017C>(entity =>
        {
            entity.ToTable("AccGl2017C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2018C>(entity =>
        {
            entity.ToTable("AccGl2018C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2019C>(entity =>
        {
            entity.ToTable("AccGl2019C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccGl2023BkOct>(entity =>
        {
            entity.ToTable("AccGl2023BkOct");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.VoucherNew).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccJrlEditConfig>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccJrlEditConfig");
        });

        modelBuilder.Entity<AccKfi>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("AccKFI");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Particulars).IsUnicode(false);
            entity.Property(e => e.Y1).HasColumnName("y1");
            entity.Property(e => e.Y1n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y1n");
            entity.Property(e => e.Y2).HasColumnName("y2");
            entity.Property(e => e.Y2n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y2n");
            entity.Property(e => e.Y3).HasColumnName("y3");
            entity.Property(e => e.Y3n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y3n");
            entity.Property(e => e.Y4).HasColumnName("y4");
            entity.Property(e => e.Y4n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y4n");
        });

        modelBuilder.Entity<AccKfimanual>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccKFIManual");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.Particulars)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccKfiold>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccKFIOld");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Particulars).IsUnicode(false);
            entity.Property(e => e.Y1).HasColumnName("y1");
            entity.Property(e => e.Y1n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y1n");
            entity.Property(e => e.Y2).HasColumnName("y2");
            entity.Property(e => e.Y2n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y2n");
            entity.Property(e => e.Y3).HasColumnName("y3");
            entity.Property(e => e.Y3n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y3n");
            entity.Property(e => e.Y4).HasColumnName("y4");
            entity.Property(e => e.Y4n)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("y4n");
        });

        modelBuilder.Entity<AccLedgerAccess>(entity =>
        {
            entity.ToTable("AccLedgerAccess");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<AccRcpsetting>(entity =>
        {
            entity.ToTable("AccRCPSetting");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasMaxLength(50);
        });

        modelBuilder.Entity<AccRoi>(entity =>
        {
            entity.ToTable("AccROI");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AccRptSetting>(entity =>
        {
            entity.ToTable("AccRptSetting");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Rpt).HasMaxLength(50);
        });

        modelBuilder.Entity<AccTempCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Accgl2021x");

            entity.ToTable("AccTempCheck");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<AccTransTemp>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccTransTemp");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(500);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.Debit).HasColumnType("money");
            entity.Property(e => e.EntryBy).HasMaxLength(50);
        });

        modelBuilder.Entity<AccUpdateList>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccUpdateList");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.Bid)
                .HasMaxLength(50)
                .HasColumnName("BId");
            entity.Property(e => e.Blevel)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BLevel");
            entity.Property(e => e.Bname).HasColumnName("BName");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .HasColumnName("DBName");
            entity.Property(e => e.IdCol).HasMaxLength(50);
        });

        modelBuilder.Entity<AccUpdateListNew>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccUpdateListNew");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.Bid)
                .HasMaxLength(50)
                .HasColumnName("BId");
            entity.Property(e => e.Blevel)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BLevel");
            entity.Property(e => e.Bname).HasColumnName("BName");
            entity.Property(e => e.Dbname)
                .HasMaxLength(50)
                .HasColumnName("DBName");
            entity.Property(e => e.IdCol).HasMaxLength(50);
        });

        modelBuilder.Entity<AccUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserRole");

            entity.ToTable("AccUserRole");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccUserRoleMap>(entity =>
        {
            entity.ToTable("AccUserRoleMap");
        });

        modelBuilder.Entity<AccVoucherAuth>(entity =>
        {
            entity.ToTable("AccVoucherAuth");

            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<AccVoucherReferral>(entity =>
        {
            entity.ToTable("AccVoucherReferral");

            entity.Property(e => e.Comments)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.RefBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefTo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReferDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Accgl2017>(entity =>
        {
            entity.ToTable("Accgl2017");

            entity.HasIndex(e => e.ActCode, "IX_Accgl2017_1");

            entity.HasIndex(e => e.Id, "Vstmt_Accgl2017").HasFillFactor(90);

            entity.HasIndex(e => e.VoucherNo, "vNO_Accgl2017_2").HasFillFactor(90);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2018>(entity =>
        {
            entity.ToTable("Accgl2018");

            entity.HasIndex(e => e.AccStatement, "AccStmt_Accgl2018").HasFillFactor(90);

            entity.HasIndex(e => e.ActCode, "ActCode_Accgl2018").HasFillFactor(90);

            entity.HasIndex(e => e.EntryDate, "EntryDate_Accgl2018").HasFillFactor(90);

            entity.HasIndex(e => e.VoucherNo, "Vno_Accgl2018").HasFillFactor(90);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2019>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Accgl2019");

            entity.HasIndex(e => e.ActCode, "ActCode_Accgl2019");

            entity.HasIndex(e => e.AccStatement, "ActStmt_Accgl2019");

            entity.HasIndex(e => e.EntryDate, "IX_Accgl2019").IsDescending();

            entity.HasIndex(e => e.VoucherNo, "Vno_Accgl2019");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2020>(entity =>
        {
            entity.ToTable("Accgl2020");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2020C>(entity =>
        {
            entity.ToTable("Accgl2020C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2021>(entity =>
        {
            entity.ToTable("Accgl2021");

            entity.HasIndex(e => e.AccStatement, "AccStatement_Accgl2021_Idx");

            entity.HasIndex(e => e.ActCode, "ActCode_Accgl2021_ActCode");

            entity.HasIndex(e => e.EntryDate, "EntryDate_Accgl2021_Idx");

            entity.HasIndex(e => e.FromActCode, "FromActCode_Accgl2021_Idx");

            entity.HasIndex(e => e.ToActCode, "ToActCode_Accgl2021_Idx");

            entity.HasIndex(e => e.VoucherNo, "VoucherNo_Accgl2021_Idx");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl20211>(entity =>
        {
            entity.ToTable("Accgl20211");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2021C>(entity =>
        {
            entity.ToTable("Accgl2021C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022>(entity =>
        {
            entity.ToTable("Accgl2022", tb => tb.HasTrigger("DeleteDataSave"));

            entity.HasIndex(e => new { e.ActCode, e.FromActCode, e.ToActCode }, "IDX_Accgl_Act_Code");

            entity.HasIndex(e => new { e.DelUser, e.EntryDate }, "InsuranceDB_SQLOPS_Accgl2022_1192531_1192530");

            entity.HasIndex(e => e.AccStatement, "InsuranceDB_SQLOPS_Accgl2022_2379988_2379987");

            entity.HasIndex(e => e.VoucherNo, "VoucherNoIdx").HasFillFactor(90);

            entity.HasIndex(e => e.EntryDate, "indx_Accgl2022_EntryDate");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("datetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl20221>(entity =>
        {
            entity.ToTable("Accgl2022S", tb => tb.HasTrigger("DeleteDataSave2022S"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022C>(entity =>
        {
            entity.ToTable("Accgl2022C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022R>(entity =>
        {
            entity.ToTable("Accgl2022R");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022R2>(entity =>
        {
            entity.ToTable("Accgl2022R2");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022R3>(entity =>
        {
            entity.ToTable("Accgl2022R3");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022R4>(entity =>
        {
            entity.ToTable("Accgl2022R4");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022R6jul>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Accgl2022R6Jul");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2022d>(entity =>
        {
            entity.ToTable("Accgl2022d");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("datetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2023>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Accgl2023", tb => tb.HasTrigger("DeleteDataSave23"));

            entity.HasIndex(e => e.AccStatement, "InsuranceDB_SQLOPS_Accgl2023_2374587_2374586").HasFillFactor(90);

            entity.HasIndex(e => e.VoucherNo, "InsuranceDB_SQLOPS_Accgl2023_9916_9915").HasFillFactor(90);

            entity.HasIndex(e => new { e.ActCode, e.EntryDate }, "indx_Accgl2023_ActCode").HasFillFactor(90);

            entity.HasIndex(e => e.DelUser, "indx_Accgl2023_DelUser_ActCode_DAmount_CAmount_AccStatement");

            entity.HasIndex(e => new { e.DelUser, e.EntryDate }, "indx_Accgl2023_DelUser_EntryDate");

            entity.HasIndex(e => e.AccStatement, "ix_AccGl2023_AccStatement").HasFillFactor(90);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2023Bkp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Accgl2023_BKP");

            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance).HasMaxLength(10);
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2023C>(entity =>
        {
            entity.ToTable("Accgl2023C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2024>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Accgl2024", tb => tb.HasTrigger("DeleteDataSave24"));

            entity.HasIndex(e => e.AccStatement, "indx_AccStatement_2024").HasFillFactor(90);

            entity.HasIndex(e => new { e.ActCode, e.DelUser, e.EntryDate }, "indx_Accgl2024_ActCode_DelUser_EntryDate");

            entity.HasIndex(e => new { e.ActCode, e.EntryDate }, "indx_ActCode_EntryDate_2024").HasFillFactor(90);

            entity.HasIndex(e => new { e.DelUser, e.EntryDate }, "indx_DelUser_EntryDate_2024").HasFillFactor(90);

            entity.HasIndex(e => e.VoucherNo, "indx_VoucherNo_2024").HasFillFactor(90);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2024C>(entity =>
        {
            entity.ToTable("Accgl2024C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Accgl2025");

            entity.HasIndex(e => e.AccStatement, "indx_AccStatement_2025").HasFillFactor(90);

            entity.HasIndex(e => new { e.ActCode, e.DelUser, e.EntryDate }, "indx_Accgl2025_ActCode_DelUser_EntryDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.ActCode, e.EntryDate }, "indx_ActCode_EntryDate_2025").HasFillFactor(90);

            entity.HasIndex(e => new { e.DelUser, e.EntryDate }, "indx_DelUser_EntryDate_2025").HasFillFactor(90);

            entity.HasIndex(e => e.VoucherNo, "indx_VoucherNo_2025").HasFillFactor(90);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Accgl2025C>(entity =>
        {
            entity.ToTable("Accgl2025C");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccglDeleted>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_AccglAccglDeleted")
                .HasFillFactor(90);

            entity.ToTable("AccglDeleted");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.DeleteDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeletedId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccglDeletedNew>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_AccglAccglDeletedNew")
                .HasFillFactor(90);

            entity.ToTable("AccglDeletedNew");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.DeletedId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DeletedNewate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AccglDeletedUpdate>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_AccglAccglDeletedUpdate")
                .HasFillFactor(90);

            entity.ToTable("AccglDeletedUpdate");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.DeletedId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DeletedUpdateate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode)
                .HasMaxLength(50)
                .HasDefaultValue("NA");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ActivePol2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ActivePol2023");

            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ActuaryValuation>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("ActuaryValuation");

            entity.Property(e => e.Sl).ValueGeneratedNever();
            entity.Property(e => e.CommencementDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnType("datetime");
            entity.Property(e => e.ExtraAnnualPrem).HasColumnName("Extra_Annual_Prem");
            entity.Property(e => e.ExtraPrem).HasColumnName("Extra_Prem");
            entity.Property(e => e.FirstDComYy)
                .HasColumnType("datetime")
                .HasColumnName("First_D_Com_yy");
            entity.Property(e => e.FprDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.LastPayDate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Pay_Date");
            entity.Property(e => e.LifeAnnualPrem).HasColumnName("Life_Annual_Prem");
            entity.Property(e => e.LifePrem).HasColumnName("Life_Prem");
            entity.Property(e => e.PayMode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Pay_Mode");
            entity.Property(e => e.PlanName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SuppAnnualPrem).HasColumnName("Supp_Annual_Prem");
            entity.Property(e => e.SuppPrem).HasColumnName("Supp_Prem");
            entity.Property(e => e.TotAnnualPrem).HasColumnName("Tot_Annual_Prem");
            entity.Property(e => e.TotPrem).HasColumnName("Tot_Prem");
        });

        modelBuilder.Entity<AdjustmentLedger>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AdjustmentLedger");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Particular).IsUnicode(false);
            entity.Property(e => e.ParticularType).IsUnicode(false);
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdmLogin>(entity =>
        {
            entity.ToTable("AdmLogin");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.AdmLogins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AdmLogin_AdmUsers");
        });

        modelBuilder.Entity<AdmRole>(entity =>
        {
            entity.Property(e => e.RoleName).HasMaxLength(100);
        });

        modelBuilder.Entity<AdmUser>(entity =>
        {
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AdvSalTemp>(entity =>
        {
            entity.HasKey(e => e.AdvanceId).HasFillFactor(90);

            entity.ToTable("AdvSalTemp");

            entity.Property(e => e.AdvanceType).HasDefaultValue(0);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.Remaining).HasDefaultValue(0.0);
            entity.Property(e => e.RepayAmount).HasDefaultValue(0);
            entity.Property(e => e.RepayPercent).HasDefaultValue(0);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdvacceAgainstExpName>(entity =>
        {
            entity.ToTable("AdvacceAgainstExpName");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdvancePremium2021>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_AdvancePremium")
                .HasFillFactor(90);

            entity.ToTable("AdvancePremium2021");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TxInfo).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AdvancePremium2022>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AdvancePremium2022");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TxInfo).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AdvancePremium2023>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AdvancePremium2023");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TxInfo).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AdvancePremium2024>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AdvancePremium2024");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TxInfo).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AdvancePremium2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AdvancePremium2025");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TxInfo).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AdvanceSalaryRequest>(entity =>
        {
            entity.HasKey(e => e.AdvanceId).HasFillFactor(90);

            entity.ToTable("AdvanceSalaryRequest");

            entity.Property(e => e.AdvanceType).HasDefaultValue(0);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.InterestAmount).HasDefaultValue(0.0);
            entity.Property(e => e.NoOfInstallments).HasDefaultValue(0);
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.Remaining).HasDefaultValue(0.0);
            entity.Property(e => e.RepayAmount).HasDefaultValue(0);
            entity.Property(e => e.RepayPercent).HasDefaultValue(0);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdvanceSalaryRequestBkp210425>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AdvanceSalaryRequest_BKP_210425");

            entity.Property(e => e.AdvanceId).ValueGeneratedOnAdd();
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdvanceType>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AdvanceType");

            entity.Property(e => e.AdvanceType1).HasColumnName("AdvanceType");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdvancedAgainstExp>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AdvancedAgainstExp");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.Com).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpenseType).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Iuno)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IUNo");
            entity.Property(e => e.NameId).HasColumnName("NameID");
            entity.Property(e => e.Payment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Vno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VNo");
        });

        modelBuilder.Entity<AdvisorTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AdvisorTracking");

            entity.Property(e => e.CreateByAgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.LifeStage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyRiskCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrackingCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentBasicInfo>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasFillFactor(90);

            entity.ToTable("AgentBasicInfo");

            entity.HasIndex(e => e.AgentName, "AgentName_AgentBasicInfo").HasFillFactor(90);

            entity.HasIndex(e => e.Mobile, "Mobile_AgentBasicInfo").HasFillFactor(90);

            entity.HasIndex(e => e.NidpassNo, "Unique_AgentBasicInfo")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AcaStatus).HasDefaultValue(0);
            entity.Property(e => e.AcademicFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgentFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgentMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AgentSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankAcno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BankACNo");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDocFileName).IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurOccupation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EduQualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EduUploadFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.GuardianAge)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GuardianName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GuardianRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImgStatus).HasDefaultValue(0);
            entity.Property(e => e.LicenseFeeStatus).HasDefaultValue(0);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NidFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NidStatus).HasDefaultValue(0);
            entity.Property(e => e.NidpassNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIDPassNo");
            entity.Property(e => e.NidpassNoEncrypted).HasColumnName("NIDPassNo_Encrypted");
            entity.Property(e => e.NomineeAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAge)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgProvideAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OrgProvideDesignation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgProvideName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OrgProvideRelation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Ref1Address).IsUnicode(false);
            entity.Property(e => e.Ref1MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref1Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ref1Occcupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref2Address).IsUnicode(false);
            entity.Property(e => e.Ref2MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref2Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ref2Occcupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoutingNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TINNo");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentBusinessOneYr>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentBusinessOneYr");

            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
        });

        modelBuilder.Entity<AgentBusinessQtr>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentBusinessQtr");

            entity.HasIndex(e => new { e.AgentId, e.Designation, e.Orstatus, e.Qtr, e.BusinessYr }, "indx_AgentBusinessQtr_AgentId_Designation_ORStatus_Qtr_BusinessYr").HasFillFactor(90);

            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Allowance).HasDefaultValue(0.0);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaSalQualified).HasDefaultValue(0);
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.PersonalLapse).HasDefaultValue(0);
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.Tds).HasColumnName("TDS");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
        });

        modelBuilder.Entity<AgentBusinessTwoYr>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentBusinessTwoYr");

            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.PostedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
        });

        modelBuilder.Entity<AgentBusinessTwoYrBkp>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentBusinessTwoYr_BKP");

            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
        });

        modelBuilder.Entity<AgentCalender>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AgentCalender");

            entity.Property(e => e.CalTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CraetedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<AgentComCalcDetail>(entity =>
        {
            entity.HasKey(e => e.AgentComId);

            entity.HasIndex(e => e.AgentId, "AgentId_AgentComCalcDetails");

            entity.HasIndex(e => e.Forward, "Forward_AgentComCalcDetails");

            entity.HasIndex(e => e.Fprid, "FprId_AgentComCalcDetails").HasFillFactor(90);

            entity.HasIndex(e => e.ComDate, "IX_AgentComCalcDetails").IsDescending();

            entity.HasIndex(e => new { e.AgentTypeName, e.ComDate }, "IndAgentTypeComDate").HasFillFactor(90);

            entity.HasIndex(e => e.InstallmentNumber, "InsNo_AgentComCalcDetails");

            entity.HasIndex(e => e.PolicyId, "PolicyId_AgentComCalcDetails")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Prnumber, "PrNo_AgentComCalcDetails");

            entity.HasIndex(e => e.AgentTypeName, "TypeName_AgentComCalcDetails");

            entity.HasIndex(e => e.ComDate, "indx_AgentComCalcDetails_ComDate");

            entity.HasIndex(e => e.InstallmentNumber, "indx_AgentComCalcDetails_InstallmentNumber");

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Ic).HasColumnName("IC");
            entity.Property(e => e.Icbalance).HasColumnName("ICBalance");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentComCalcDetailsBackUp17>(entity =>
        {
            entity.HasKey(e => e.AgentComId);

            entity.ToTable("AgentComCalcDetailsBackUp17");

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Ic).HasColumnName("IC");
            entity.Property(e => e.Icbalance).HasColumnName("ICBalance");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentComCalcDetailsFeb55656>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AgentComCalcDetails_Feb_55656");

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentComId).ValueGeneratedOnAdd();
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Ic).HasColumnName("IC");
            entity.Property(e => e.Icbalance).HasColumnName("ICBalance");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentComCalcDetailsPf>(entity =>
        {
            entity.HasKey(e => e.AgentComId);

            entity.ToTable("AgentComCalcDetailsPf");

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Ic).HasColumnName("IC");
            entity.Property(e => e.Icbalance).HasColumnName("ICBalance");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentComCalcDetailsRestore>(entity =>
        {
            entity.ToTable("AgentComCalcDetails_Restore");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Ic).HasColumnName("IC");
            entity.Property(e => e.Icbalance).HasColumnName("ICBalance");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.Rc).HasColumnName("RC");
        });

        modelBuilder.Entity<AgentComPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("AgentComPayment");

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BasicComAmount).HasColumnType("money");
            entity.Property(e => e.PaymentAmount).HasColumnType("money");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Pf).HasColumnName("pf");
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.SupComAmount).HasColumnType("money");
            entity.Property(e => e.TotalPayment).HasColumnType("money");
            entity.Property(e => e.VatAmount).HasColumnType("money");
        });

        modelBuilder.Entity<AgentComRateFa>(entity =>
        {
            entity.ToTable("AgentComRate_FA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fyear).HasColumnName("FYear");
            entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");
            entity.Property(e => e.Syear).HasColumnName("SYear");
            entity.Property(e => e.Tyear).HasColumnName("TYear");
        });

        modelBuilder.Entity<AgentComTaxChallan>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AgentComTaxChallan");

            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ChallanNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.TotalAmtInChallan).HasColumnType("money");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDt).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentCommentHistory>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentCommentHistory");

            entity.HasIndex(e => e.AgentId, "AgentId_AgentCommentHistory").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("sl");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentCommissionCalculation>(entity =>
        {
            entity.ToTable("AgentCommissionCalculation");

            entity.HasIndex(e => e.AgentId, "AgentId_AgentCommissionCalculation").HasFillFactor(90);

            entity.Property(e => e.AgentAccNo).IsUnicode(false);
            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.AgentTypeName).IsUnicode(false);
            entity.Property(e => e.BranchName).IsUnicode(false);
            entity.Property(e => e.OtherInfoSt).IsUnicode(false);
            entity.Property(e => e.UserName).IsUnicode(false);
        });

        modelBuilder.Entity<AgentCommissionPr>(entity =>
        {
            entity.HasKey(e => e.AgentComId).HasName("PK_AgentCommissionPR20204");

            entity.ToTable("AgentCommissionPR");

            entity.HasIndex(e => e.AgentId, "AgentId_AgentCommissionPR_Idx");

            entity.HasIndex(e => e.AgentTypeName, "AgentTypeName_AgentCommissionPR_Idx");

            entity.HasIndex(e => e.ApplicantId, "ApplicantId_AgentCommissionPR_Idx");

            entity.HasIndex(e => new { e.BasicComAmount, e.SupComAmount, e.VatAmout }, "Basic_Sup_Vat_AgentCommissionPR_Idx");

            entity.HasIndex(e => e.ComDate, "ComDate_AgentCommissionPR_Idx");

            entity.HasIndex(e => e.Prnumber, "PRNumber_AgentCommissionPR_Idx");

            entity.HasIndex(e => e.AgentTypeName, "indx_AgentCommissionPR_AgentTypeName");

            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentContest>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentContest");

            entity.HasIndex(e => e.AgentType, "idx_AgentType");

            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueOroneYr).HasColumnName("DueOROneYr");
            entity.Property(e => e.DueOrtwoYr).HasColumnName("DueORTwoYr");
            entity.Property(e => e.Incentive).HasDefaultValue(0.0);
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
        });

        modelBuilder.Entity<AgentContestBm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AgentContestBM");

            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueOroneYr).HasColumnName("DueOROneYr");
            entity.Property(e => e.DueOrtwoYr).HasColumnName("DueORTwoYr");
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Samdname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
        });

        modelBuilder.Entity<AgentDiscontinueReason>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentDiscontinueReason");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentEarningPaid>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("AgentEarningPaid");

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BasicComAmount).HasColumnType("money");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SupComAmount).HasColumnType("money");
            entity.Property(e => e.TotalPayment).HasColumnType("money");
        });

        modelBuilder.Entity<AgentFileAllocation>(entity =>
        {
            entity.HasKey(e => e.Sl)
                .HasName("PK_UnassignedAgent")
                .HasFillFactor(90);

            entity.ToTable("AgentFileAllocation");

            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updatedate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentForwardingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.ForwardingSummaryId, "Ind_ForwardinId_NonClusteredIndex");

            entity.HasIndex(e => e.RefNo, "Ind_RefNo_NonClusteredIndex").HasFillFactor(90);

            entity.HasIndex(e => e.RefType, "Ind_RefType_NonClusteredIndex");

            entity.HasIndex(e => e.StatusFlag, "Ind_StatusFlag_NonClusteredIndex");

            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.PolicyHolderName).IsUnicode(false);
            entity.Property(e => e.RefType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UmName).IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentForwardingMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AgentForwardingMaster");

            entity.HasIndex(e => e.CreateDate, "Ind_CreateDate_NonClusteredIndex");

            entity.HasIndex(e => e.ForwardingNo, "Ind_ForwadingNo_NonClusteredIndex");

            entity.HasIndex(e => e.PaymentMode, "Ind_PaymentMode_NonClusteredIndex");

            entity.HasIndex(e => e.StatusFlag, "Ind_StatusFlag_NonClusteredIndex");

            entity.HasIndex(e => e.UpdateDate, "Ind_UpdateDate_NonClusteredIndex");

            entity.HasIndex(e => e.CreateBy, "indx_AgentForwardingMaster_CreateBy").HasFillFactor(90);

            entity.HasIndex(e => new { e.CreateBy, e.CreateDate }, "indx_AgentForwardingMaster_CreateBy_CreateDate").HasFillFactor(90);

            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentForwardingTempDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchName).IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.PolicyHolderName).IsUnicode(false);
            entity.Property(e => e.RefType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UmName).IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
        });

        modelBuilder.Entity<AgentFullChain>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AgentFullChain");

            entity.HasIndex(e => e.Samdid, "InsuranceDB_SQLOPS_AgentFullChain_2276175_2276174").HasFillFactor(90);

            entity.HasIndex(e => e.Amdid, "indx_AgentFullChain_AMDId").HasFillFactor(90);

            entity.HasIndex(e => new { e.Bmid, e.StatusFlag }, "indx_AgentFullChain_BMId_StatusFlag").HasFillFactor(90);

            entity.HasIndex(e => e.Faid, "indx_AgentFullChain_FAId").HasFillFactor(90);

            entity.HasIndex(e => new { e.Samdid, e.Amdid }, "indx_AgentFullChain_SAMDId_AMDId").HasFillFactor(90);

            entity.HasIndex(e => e.Sgmid, "indx_AgentFullChain_SGMId").HasFillFactor(90);

            entity.HasIndex(e => e.Umid, "indx_AgentFullChain_UMId").HasFillFactor(90);

            entity.Property(e => e.AmdbranchId).HasColumnName("AMDBranchId");
            entity.Property(e => e.AmdbranchName)
                .IsUnicode(false)
                .HasColumnName("AMDBranchName");
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.AmdidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMDIdNo");
            entity.Property(e => e.AmdjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMDJobStatus");
            entity.Property(e => e.AmdjoiningDate).HasColumnName("AMDJoiningDate");
            entity.Property(e => e.Amdname)
                .IsUnicode(false)
                .HasColumnName("AMDName");
            entity.Property(e => e.BcbranchId).HasColumnName("BCBranchId");
            entity.Property(e => e.BcbranchName)
                .IsUnicode(false)
                .HasColumnName("BCBranchName");
            entity.Property(e => e.Bcid).HasColumnName("BCId");
            entity.Property(e => e.BcidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCIdNo");
            entity.Property(e => e.BcjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCJobStatus");
            entity.Property(e => e.BcjoiningDate).HasColumnName("BCJoiningDate");
            entity.Property(e => e.Bcname)
                .IsUnicode(false)
                .HasColumnName("BCName");
            entity.Property(e => e.BmbranchId).HasColumnName("BMBranchId");
            entity.Property(e => e.BmbranchName)
                .IsUnicode(false)
                .HasColumnName("BMBranchName");
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.BmidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BMIdNo");
            entity.Property(e => e.BmjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BMJobStatus");
            entity.Property(e => e.BmjoiningDate).HasColumnName("BMJoiningDate");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.DcbranchId).HasColumnName("DCBranchId");
            entity.Property(e => e.DcbranchName)
                .IsUnicode(false)
                .HasColumnName("DCBranchName");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.DcidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCIdNo");
            entity.Property(e => e.DcjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCJobStatus");
            entity.Property(e => e.DcjoiningDate).HasColumnName("DCJoiningDate");
            entity.Property(e => e.Dcname)
                .IsUnicode(false)
                .HasColumnName("DCName");
            entity.Property(e => e.DvcbranchId).HasColumnName("DVCBranchId");
            entity.Property(e => e.DvcbranchName)
                .IsUnicode(false)
                .HasColumnName("DVCBranchName");
            entity.Property(e => e.Dvcid).HasColumnName("DVCId");
            entity.Property(e => e.DvcidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCIdNo");
            entity.Property(e => e.DvcjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCJobStatus");
            entity.Property(e => e.DvcjoiningDate).HasColumnName("DVCJoiningDate");
            entity.Property(e => e.Dvcname)
                .IsUnicode(false)
                .HasColumnName("DVCName");
            entity.Property(e => e.FabranchId).HasColumnName("FABranchId");
            entity.Property(e => e.FabranchName)
                .IsUnicode(false)
                .HasColumnName("FABranchName");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.FaidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAIdNo");
            entity.Property(e => e.FajobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAJobStatus");
            entity.Property(e => e.FajoiningDate).HasColumnName("FAJoiningDate");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.RcbranchId).HasColumnName("RCBranchId");
            entity.Property(e => e.RcbranchName)
                .IsUnicode(false)
                .HasColumnName("RCBranchName");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.RcidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RCIdNo");
            entity.Property(e => e.RcjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RCJobStatus");
            entity.Property(e => e.RcjoiningDate).HasColumnName("RCJoiningDate");
            entity.Property(e => e.Rcname)
                .IsUnicode(false)
                .HasColumnName("RCName");
            entity.Property(e => e.SamdbranchId).HasColumnName("SAMDBranchId");
            entity.Property(e => e.SamdbranchName)
                .IsUnicode(false)
                .HasColumnName("SAMDBranchName");
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.SamdidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAMDIdNo");
            entity.Property(e => e.SamdjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAMDJobStatus");
            entity.Property(e => e.SamdjoiningDate).HasColumnName("SAMDJoiningDate");
            entity.Property(e => e.Samdname)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.SgmbranchId).HasColumnName("SGMBranchId");
            entity.Property(e => e.SgmbranchName)
                .IsUnicode(false)
                .HasColumnName("SGMBranchName");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.SgmidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SGMIdNo");
            entity.Property(e => e.SgmjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SGMJobStatus");
            entity.Property(e => e.SgmjoiningDate).HasColumnName("SGMJoiningDate");
            entity.Property(e => e.Sgmname)
                .IsUnicode(false)
                .HasColumnName("SGMName");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UmbranchId).HasColumnName("UMBranchId");
            entity.Property(e => e.UmbranchName)
                .IsUnicode(false)
                .HasColumnName("UMBranchName");
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.UmidNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UMIdNo");
            entity.Property(e => e.UmjobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UMJobStatus");
            entity.Property(e => e.UmjoiningDate).HasColumnName("UMJoiningDate");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
        });

        modelBuilder.Entity<AgentHierarchyList>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentHierarchyList");

            entity.Property(e => e.Sl).HasColumnName("sl");
            entity.Property(e => e.Amd).HasColumnName("AMD");
            entity.Property(e => e.Bc).HasColumnName("BC");
            entity.Property(e => e.Bm).HasColumnName("BM");
            entity.Property(e => e.Dc).HasColumnName("DC");
            entity.Property(e => e.Dvc).HasColumnName("DVC");
            entity.Property(e => e.Fa).HasColumnName("FA");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.Samd).HasColumnName("SAMD");
            entity.Property(e => e.Sgm).HasColumnName("SGM");
            entity.Property(e => e.Um).HasColumnName("UM");
        });

        modelBuilder.Entity<AgentIncentiveList>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Agent_IncentiveList");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentType).IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.Createby)
                .IsUnicode(false)
                .HasColumnName("createby");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");
            entity.Property(e => e.Updateby)
                .IsUnicode(false)
                .HasColumnName("updateby");
        });

        modelBuilder.Entity<AgentJobDetail>(entity =>
        {
            entity.HasKey(e => e.AgentJobId).HasFillFactor(90);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TR_insertintoAllAgentList");
                    tb.HasTrigger("trg_Delete_Insert");
                });

            entity.HasIndex(e => e.AgentId, "AgentId_AgentJobDetails").IsUnique();

            entity.HasIndex(e => e.AgentJobStatus, "AgentJObDetails_NonCluster_AgentJob_Ind").HasFillFactor(90);

            entity.HasIndex(e => e.AgentHirearchyId, "HierId_AgentJobDetails").HasFillFactor(90);

            entity.HasIndex(e => e.AgentJobStatus, "JobStatus_AgentJobDetails").HasFillFactor(90);

            entity.HasIndex(e => e.JobStartDate, "Job_Start_Date_AgentJobDetails_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.LicenseExpiryDate, "LicenseExpiryDate_AgentJobDetails_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.UnitOfficeCode, "UnitOfficeCode_AgentJobDetails_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.UserName, "UserName_AgentJobDetails").HasFillFactor(90);

            entity.HasIndex(e => new { e.AgentJobStatus, e.AentTypeId, e.LicenseExpiryDate }, "indx_AgentJobDetails_Agent_Job_Status_AentTypeId_LicenseExpiryDate").HasFillFactor(90);

            entity.HasIndex(e => e.AentTypeId, "mrdenny_AentTypeId_Agent_Job_Status").HasFillFactor(70);

            entity.Property(e => e.ActivateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ActivateDate).HasColumnType("datetime");
            entity.Property(e => e.AgentIdNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentJobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Agent_Job_Status");
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fstatus).HasColumnName("FStatus");
            entity.Property(e => e.IdraagentCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IDRAAgentCode");
            entity.Property(e => e.IdraregistrationNo)
                .IsUnicode(false)
                .HasColumnName("IDRARegistrationNo");
            entity.Property(e => e.JobEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_End_Date");
            entity.Property(e => e.JobStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_Start_Date");
            entity.Property(e => e.LicenseStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UnitOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AentType).WithMany(p => p.AgentJobDetails)
                .HasForeignKey(d => d.AentTypeId)
                .HasConstraintName("FK_AgentJobDetails_AgentType");

            entity.HasOne(d => d.Agent).WithOne(p => p.AgentJobDetail)
                .HasForeignKey<AgentJobDetail>(d => d.AgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentJobDetails_AgentBasicInfo");
        });

        modelBuilder.Entity<AgentJobDetailsDeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AgentJobDetailsDeleted");

            entity.Property(e => e.ActivateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ActivateDate).HasColumnType("datetime");
            entity.Property(e => e.AgentIdNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentJobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Agent_Job_Status");
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IdraregistrationNo)
                .IsUnicode(false)
                .HasColumnName("IDRARegistrationNo");
            entity.Property(e => e.JobEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_End_Date");
            entity.Property(e => e.JobStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_Start_Date");
            entity.Property(e => e.LicenseStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PostingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.UnitOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentLapse>(entity =>
        {
            entity.ToTable("AgentLapse");

            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.Bcid).HasColumnName("BCId");
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCId");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.Umid).HasColumnName("UMId");
        });

        modelBuilder.Entity<AgentMeeting>(entity =>
        {
            entity.ToTable("AgentMeeting");

            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Contract)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Location)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MeetingTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentMonthlyTarget>(entity =>
        {
            entity.HasKey(e => e.TargetId);

            entity.ToTable("AgentMonthlyTarget");

            entity.Property(e => e.TargetId).HasColumnName("TargetID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TargetMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentPerfTemp1>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentPerfTemp1");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.AgentTypeName).IsUnicode(false);
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchOfficeCode).IsUnicode(false);
            entity.Property(e => e.CreateDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.SamdName).IsUnicode(false);
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Umid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMName");
        });

        modelBuilder.Entity<AgentPerfTemp2Renewal>(entity =>
        {
            entity.HasKey(e => e.Sl)
                .HasName("PK_AgentPerfTemp2")
                .HasFillFactor(90);

            entity.ToTable("AgentPerfTemp2Renewal");

            entity.HasIndex(e => e.AgentId, "AgentPerfTemp2Renewal_AgentId_Indx");

            entity.HasIndex(e => new { e.OrId, e.ApplicantName }, "IDX_AgentPerfTemp2Renewal_OrID");

            entity.HasIndex(e => e.PrNo, "IDX_AgentPerf_PrNo");

            entity.HasIndex(e => e.DepositDate, "Idx_AgentPerfTemp2Renewal");

            entity.HasIndex(e => e.Typ, "NonClusteredIndex");

            entity.HasIndex(e => e.OrId, "indx_AgentPerfTemp2Renewal_ORID");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.AgentTypeName).IsUnicode(false);
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchOfficeCode).IsUnicode(false);
            entity.Property(e => e.CreateDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.IsDeferred).HasColumnName("isDeferred");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.SamdName).IsUnicode(false);
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Umid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMName");
        });

        modelBuilder.Entity<AgentPerfTemp2Renewal02122025>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AgentPerfTemp2Renewal_02122025");

            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.AgentTypeName).IsUnicode(false);
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchOfficeCode).IsUnicode(false);
            entity.Property(e => e.CreateDt).HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.IsDeferred).HasColumnName("isDeferred");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.SamdName).IsUnicode(false);
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Umid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMName");
        });

        modelBuilder.Entity<AgentPerfTemp2RenewalCopy>(entity =>
        {
            entity.HasKey(e => e.Sl)
                .HasName("PK_AgentPerfTemp2Copy")
                .HasFillFactor(90);

            entity.ToTable("AgentPerfTemp2RenewalCopy");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.AgentTypeName).IsUnicode(false);
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchOfficeCode).IsUnicode(false);
            entity.Property(e => e.CreateDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.MainSl).HasColumnName("MainSL");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.SamdName).IsUnicode(false);
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Umid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMName");
        });

        modelBuilder.Entity<AgentPerfTemp2RenewalCurrent>(entity =>
        {
            entity.HasKey(e => e.Sl)
                .HasName("PK_AgentPerfTemp2Current")
                .HasFillFactor(90);

            entity.ToTable("AgentPerfTemp2RenewalCurrent");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.AgentTypeName).IsUnicode(false);
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchOfficeCode).IsUnicode(false);
            entity.Property(e => e.CreateDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.MainSl).HasColumnName("MainSL");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PrNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.SamdName).IsUnicode(false);
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Umid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMName");
        });

        modelBuilder.Entity<AgentPerformanceReport>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentPerformanceReport");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentName).IsUnicode(false);
            entity.Property(e => e.AgentTypeName).IsUnicode(false);
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bmid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchOfficeCode).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Faid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Samd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMD");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UMName");
        });

        modelBuilder.Entity<AgentPersonalLapse>(entity =>
        {
            entity.ToTable("AgentPersonalLapse");

            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentRanking>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentRanking");

            entity.HasIndex(e => e.AgentAccNo, "AgentAccNo_AgentRanking_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.AgentTypeName, "AgentTypeName_AgentRanking_Idx");

            entity.HasIndex(e => new { e.AgentId, e.AgentName }, "Agent_AgentRanking_Idx").HasFillFactor(90);

            entity.HasIndex(e => new { e.BranchId, e.BranchName }, "Branch_AgentRanking_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.JobDuration, "JobDuration_AgentRanking_Idx").HasFillFactor(90);

            entity.HasIndex(e => new { e.NoOfPr, e.PremiumAmount, e.TotalCommission, e.VatAmount, e.NetRetention }, "NoOfPR_Premium_Vat_Retention_AgentRanking_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.RankDate, "RankDate_AgentRanking_Idx");

            entity.HasIndex(e => e.ReportType, "ReportType_AgentRanking_Idx");

            entity.HasIndex(e => new { e.Samdid, e.Samdname }, "Samd_AgentRanking_Idx").HasFillFactor(90);

            entity.Property(e => e.AgentAccNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Samdname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
        });

        modelBuilder.Entity<AgentSalary>(entity =>
        {
            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fdramount).HasColumnName("FDRAmount");
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.ReportType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.TotalFdr).HasColumnName("TotalFDR");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentSalary1>(entity =>
        {
            entity.HasKey(e => e.AgentSalaryId);

            entity.ToTable("AgentSalary");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeductionDescription).IsUnicode(false);
        });

        modelBuilder.Entity<AgentSalaryApril>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentSalaryApril");

            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentSalaryJune>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AgentSalaryJune");

            entity.Property(e => e.Purpose)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentSalarySetup>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("AgentSalarySetup");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FromAgentBusinessType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FromAgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToAgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentType>(entity =>
        {
            entity.ToTable("AgentType");

            entity.HasIndex(e => new { e.AgentTypeName, e.AgentTypeShortFrom }, "Unique_AgentType");

            entity.HasIndex(e => e.Hierarchy, "Unique_Hierarchy_AgentType").IsUnique();

            entity.Property(e => e.AgentIdSequence)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(450)
                .IsUnicode(false);
            entity.Property(e => e.AgentTypeShortFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentTypeShortFromNew)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.RenewReminder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgentTypeTarget>(entity =>
        {
            entity.ToTable("AgentTypeTarget");

            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TargetMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentYearlyTarget>(entity =>
        {
            entity.HasKey(e => e.TargetId).HasFillFactor(90);

            entity.ToTable("AgentYearlyTarget");

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AllAgentList>(entity =>
        {
            entity.HasKey(e => e.Slno);

            entity.ToTable("AllAgentList");

            entity.Property(e => e.Slno).HasColumnName("SLno");
            entity.Property(e => e.Amdid).HasColumnName("AMDid");
            entity.Property(e => e.Bcid).HasColumnName("BCid");
            entity.Property(e => e.Bmid).HasColumnName("BMid");
            entity.Property(e => e.Dcid).HasColumnName("DCid");
            entity.Property(e => e.Dvcid).HasColumnName("DVCid");
            entity.Property(e => e.Faid).HasColumnName("FAid");
            entity.Property(e => e.Rcid).HasColumnName("RCid");
            entity.Property(e => e.Samdid).HasColumnName("SAMDid");
            entity.Property(e => e.Sgmid).HasColumnName("SGMid");
            entity.Property(e => e.Umid).HasColumnName("UMid");
        });

        modelBuilder.Entity<AllowableExpenseRateChart>(entity =>
        {
            entity.ToTable("AllowableExpenseRateChart", "Expenses");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllowableExpenseAgency).HasColumnName("AllowableExpense_Agency");
            entity.Property(e => e.AllowableExpenseMgmt).HasColumnName("AllowableExpense_Mgmt");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AllowableExpenseRateChartHistory>(entity =>
        {
            entity.ToTable("AllowableExpenseRateChart_History", "Expenses");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aercid).HasColumnName("AERCID");
            entity.Property(e => e.AllowableExpenseAgency).HasColumnName("AllowableExpense_Agency");
            entity.Property(e => e.AllowableExpenseMgmt).HasColumnName("AllowableExpense_Mgmt");
            entity.Property(e => e.CreateDate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AltHistoryUnlimited>(entity =>
        {
            entity.HasKey(e => e.AltHistoryId);

            entity.ToTable("AltHistoryUnlimited");

            entity.Property(e => e.AlterationCase)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AlterationInformation).IsUnicode(false);
            entity.Property(e => e.CaseCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
        });

        modelBuilder.Entity<AlterMasterPolicy>(entity =>
        {
            entity.HasKey(e => e.AlterMasterId).HasFillFactor(90);

            entity.ToTable("AlterMasterPolicy", tb => tb.HasTrigger("TRG_InsertAlterPayments"));

            entity.Property(e => e.AlterMasterId).HasColumnName("AlterMasterID");
            entity.Property(e => e.AlterSaflag).HasColumnName("AlterSAflag");
            entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            entity.Property(e => e.BasicPremiumAmount).HasDefaultValue(0.0);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.OrentryId).HasColumnName("OREntryId");
            entity.Property(e => e.OrmasterId).HasColumnName("ORMasterId");
            entity.Property(e => e.PolicyRiskAdditonalFactor).IsUnicode(false);
            entity.Property(e => e.SupplementaryAmount).HasDefaultValue(0.0);
            entity.Property(e => e.SupplimentaryId).HasColumnName("SupplimentaryID");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Ysapa).HasColumnName("ysapa");
        });

        modelBuilder.Entity<AlterPayment>(entity =>
        {
            entity.HasKey(e => e.AltPaymentId).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("AltarationAgeVerify"));

            entity.HasIndex(e => new { e.FprId, e.IsPaid }, "indx_AlterPayments_FprID_IsPaid").HasFillFactor(90);

            entity.Property(e => e.AltPaymentId).HasColumnName("AltPaymentID");
            entity.Property(e => e.AltHis)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.AppId).HasColumnName("AppID");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FprId).HasColumnName("FprID");
            entity.Property(e => e.PaymentMethod).IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlterationCase>(entity =>
        {
            entity.HasKey(e => e.CaseId);

            entity.ToTable("AlterationCase");

            entity.Property(e => e.CaseId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CaseName).IsUnicode(false);
        });

        modelBuilder.Entity<AlterationHistory>(entity =>
        {
            entity.HasKey(e => e.AltHistoryId);

            entity.ToTable("AlterationHistory");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.PermanentAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UploadDocsId)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UploadDocsName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UploadDocsPhoto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UploadPhoto)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmOdoMeter>(entity =>
        {
            entity.HasKey(e => e.Mvid);

            entity.ToTable("AM_OdoMeter");

            entity.Property(e => e.Mvid).HasColumnName("MVID");
            entity.Property(e => e.AssetMasterId).HasColumnName("AssetMasterID");
            entity.Property(e => e.AssetNameId).HasColumnName("AssetNameID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApiResponse>(entity =>
        {
            entity.ToTable("ApiResponse");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<ApiResponse2019>(entity =>
        {
            entity.ToTable("ApiResponse2019");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<ApiResponse2020>(entity =>
        {
            entity.ToTable("ApiResponse2020");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<ApiResponse2021>(entity =>
        {
            entity.ToTable("ApiResponse2021");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<ApiResponse2022>(entity =>
        {
            entity.ToTable("ApiResponse2022");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<ApiResponse2023>(entity =>
        {
            entity.ToTable("ApiResponse2023");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<ApiResponse2024>(entity =>
        {
            entity.ToTable("ApiResponse2024");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<Apiresponse2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("APIResponse2025");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Response).IsUnicode(false);
        });

        modelBuilder.Entity<AppId>(entity =>
        {
            entity.HasKey(e => e.AppId1);

            entity.ToTable("AppID");

            entity.Property(e => e.AppId1)
                .ValueGeneratedNever()
                .HasColumnName("AppId");
        });

        modelBuilder.Entity<AppNotification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK_AppNotification2");

            entity.ToTable("AppNotification", tb => tb.HasTrigger("SendAppNotificationNew"));

            entity.HasIndex(e => e.StatusFlag, "indx_AppNotification_StatusFlag");

            entity.Property(e => e.AppType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .IsUnicode(false)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.StatusFlag).HasDefaultValue(0);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppNotificationOld>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK_AppNotification");

            entity.ToTable("AppNotificationOld", tb => tb.HasTrigger("SendAppNotification"));

            entity.Property(e => e.AppType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .IsUnicode(false)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.StatusFlag).HasDefaultValue(0);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.ToTable("AppUser");

            entity.HasIndex(e => e.TypeName, "TypeName_AppUser").HasFillFactor(90);

            entity.HasIndex(e => e.UserId, "UserId_AppUser").HasFillFactor(90);

            entity.HasIndex(e => e.UserName, "UserName_AppUser").HasFillFactor(90);

            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateCardBy).IsUnicode(false);
            entity.Property(e => e.UpdateCardDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApplicantApprovalUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FileApprovalUser");

            entity.ToTable("ApplicantApprovalUser");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApplicantInfo2023Del>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ApplicantInfo2023Del");

            entity.Property(e => e.Acc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AncestralDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentName).IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantId).ValueGeneratedOnAdd();
            entity.Property(e => e.ApplicantIdno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ApplicantIDNo");
            entity.Property(e => e.ApplicantMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantNameBang).HasMaxLength(500);
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPhotoName).IsUnicode(false);
            entity.Property(e => e.ApplicantPpname)
                .IsUnicode(false)
                .HasColumnName("ApplicantPPName");
            entity.Property(e => e.ApplicantSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlace).IsUnicode(false);
            entity.Property(e => e.ChestSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPoxVaccin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentHeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentWeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentlyWell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EduQualification).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EpilepticProblem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EyeDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FrequentCough)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GoitrousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificationMark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InfectiousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LongHolidayForIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiltDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PhysicalDisability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderSignature).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SmsFormate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StomachInfection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SummeryCommentBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SummeryCommentDate).HasColumnType("datetime");
            entity.Property(e => e.TypesOfOperation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnderWrittingComments).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UploadDocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UploadDocumentID");
            entity.Property(e => e.UrineStone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uwcomments)
                .IsUnicode(false)
                .HasColumnName("UWComments");
            entity.Property(e => e.Uwstatus).HasColumnName("UWStatus");
            entity.Property(e => e.WaistSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeightLossOrGain)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenBaby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEarnAbility)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEduQualification).IsUnicode(false);
            entity.Property(e => e.WomenHusbandMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandName)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKids)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKidsExpectation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenLastPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenPayTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenSourceOfIncome)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApplicationFileAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ApplicationFileAllocation");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.FileType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppsGrievance>(entity =>
        {
            entity.ToTable("AppsGrievance");

            entity.Property(e => e.ComplainType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.GrievanceStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserReference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppsVersion>(entity =>
        {
            entity.ToTable("AppsVersion");

            entity.Property(e => e.AppName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Discriminator).HasMaxLength(128);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.ProviderKey }).HasName("PK_dbo.AspNetUserLogins");

            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId }).HasName("PK_dbo.AspNetUserRoles");

            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.RoleId).HasMaxLength(128);
        });

        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.ToTable("Assessment");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AssetAssign>(entity =>
        {
            entity.ToTable("AssetAssign");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AssetMaintenance>(entity =>
        {
            entity.HasKey(e => e.MaintenId);

            entity.ToTable("AssetMaintenance");

            entity.Property(e => e.CodeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetMaintenancePay>(entity =>
        {
            entity.HasKey(e => e.MpayId);

            entity.ToTable("AssetMaintenancePay");

            entity.Property(e => e.MpayId).HasColumnName("MPayId");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Mnotes)
                .IsUnicode(false)
                .HasColumnName("MNotes");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetMaster>(entity =>
        {
            entity.HasKey(e => e.MasterId);

            entity.ToTable("AssetMaster");

            entity.Property(e => e.MasterId).HasColumnName("MasterID");
            entity.Property(e => e.AssetNameId).HasColumnName("AssetNameID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetName>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("AssetName", tb => tb.HasTrigger("UpdateAssetName_Trg"));

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AssetName1)
                .IsUnicode(false)
                .HasColumnName("AssetName");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetSale>(entity =>
        {
            entity.HasKey(e => e.SalesId);

            entity.Property(e => e.CodeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.SalesStatus).HasDefaultValue(0);
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetStock>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("AssetStock", tb =>
                {
                    tb.HasTrigger("InsertToAssetMaster");
                    tb.HasTrigger("UpdateAssetMaster");
                });

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.AssetNameId).HasColumnName("AssetNameID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.Branch).IsUnicode(false);
            entity.Property(e => e.CalcDone).HasMaxLength(50);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo).HasMaxLength(100);
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.ToTable("AssetType");

            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.AssetTypeName).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssigneeInformation>(entity =>
        {
            entity.HasKey(e => e.AssigneeId).HasFillFactor(90);

            entity.ToTable("AssigneeInformation");

            entity.Property(e => e.AssigneeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChooseDocuments)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UploadDocs)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UploadPp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UploadPP");
        });

        modelBuilder.Entity<AuditClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AuditClaim");

            entity.Property(e => e.ClaimDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ClaimNotificationDate).HasMaxLength(30);
            entity.Property(e => e.ClaimStatus).IsUnicode(false);
            entity.Property(e => e.ClaimType).IsUnicode(false);
            entity.Property(e => e.CommencementDate).HasMaxLength(30);
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.DecisionDate).HasMaxLength(30);
            entity.Property(e => e.OcfreceivingDate)
                .HasMaxLength(30)
                .HasColumnName("OCFreceivingDate");
            entity.Property(e => e.PaidDate).HasMaxLength(30);
            entity.Property(e => e.PolicyNo).IsUnicode(false);
            entity.Property(e => e.SettlementDuration1).HasMaxLength(50);
        });

        modelBuilder.Entity<AuditVoucherList>(entity =>
        {
            entity.ToTable("AuditVoucherList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccStatement).HasMaxLength(100);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(100);
            entity.Property(e => e.Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Camount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CAmount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelUser).HasMaxLength(50);
            entity.Property(e => e.Excel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FromActCode).HasMaxLength(50);
            entity.Property(e => e.JournalId).HasColumnName("JournalID");
            entity.Property(e => e.ToActCode).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
            entity.Property(e => e.VoucherNoMain).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoAgentCommission>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Auto_AgentCommission");

            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ait).HasDefaultValue(0.0);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ComStatus).HasDefaultValue(0);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.ReportType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AutoAgentCommissionBkp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Auto_AgentCommission_BKP");

            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.ReportType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AutoAgentSalary>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Auto_AgentSalaries");

            entity.HasIndex(e => e.AgentGroup, "Idx_AgentGroup_Sal");

            entity.HasIndex(e => e.ReportType, "Idx_ReportType_Sal");

            entity.HasIndex(e => e.SalMonth, "Idx_SalMonth_Sal");

            entity.HasIndex(e => e.SalYear, "Idx_SalYear_Sal");

            entity.HasIndex(e => e.Samdid, "Idx_SamdId_Sal").HasFillFactor(90);

            entity.HasIndex(e => e.Organization, "Idx_designation_Sal").HasFillFactor(90);

            entity.HasIndex(e => e.AgentId, "idx_AgentId_Sal").HasFillFactor(90);

            entity.Property(e => e.AgentGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeferredPercentOneYr).HasDefaultValue(0.0);
            entity.Property(e => e.DeferredPercentTwoYr).HasDefaultValue(0.0);
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DueOroneYr)
                .HasDefaultValue(0.0)
                .HasColumnName("DueOROneYr");
            entity.Property(e => e.DueOrtwoYr)
                .HasDefaultValue(0.0)
                .HasColumnName("DueORTwoYr");
            entity.Property(e => e.DueRenOneYr).HasDefaultValue(0.0);
            entity.Property(e => e.DueRenTwoYr).HasDefaultValue(0.0);
            entity.Property(e => e.ExtraIncentive).HasDefaultValue(0.0);
            entity.Property(e => e.Fdramount).HasColumnName("FDRAmount");
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LapseOroneYr)
                .HasDefaultValue(0.0)
                .HasColumnName("LapseOROneYr");
            entity.Property(e => e.LapseOrtwoYr)
                .HasDefaultValue(0.0)
                .HasColumnName("LapseORTwoYr");
            entity.Property(e => e.LapseRenOneYr).HasDefaultValue(0.0);
            entity.Property(e => e.LapseRenTwoYr).HasDefaultValue(0.0);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OroneYr)
                .HasDefaultValue(0.0)
                .HasColumnName("OROneYr");
            entity.Property(e => e.OrtwoYr)
                .HasDefaultValue(0.0)
                .HasColumnName("ORTwoYr");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.Prod23Amount).HasDefaultValue(0.0);
            entity.Property(e => e.Prod23Pol).HasDefaultValue(0);
            entity.Property(e => e.RenOneYr).HasDefaultValue(0.0);
            entity.Property(e => e.RenTwoYr).HasDefaultValue(0.0);
            entity.Property(e => e.RenewalPercentOneYr).HasDefaultValue(0.0);
            entity.Property(e => e.RenewalPercentTwoYr).HasDefaultValue(0.0);
            entity.Property(e => e.ReportType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalAddition).HasDefaultValue(0.0);
            entity.Property(e => e.SalDeduction).HasDefaultValue(0.0);
            entity.Property(e => e.SalStatus).HasDefaultValue(0);
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Samdname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SAMDName");
            entity.Property(e => e.Tds).HasColumnName("TDS");
            entity.Property(e => e.TotalFdr).HasColumnName("TotalFDR");
            entity.Property(e => e.TotalPr).HasColumnName("TotalPR");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BKashLiability10252023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bKashLiability_10252023");

            entity.Property(e => e.AccStatement)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.TransactionNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<BackToPrRequest>(entity =>
        {
            entity.ToTable("BackToPrRequest");

            entity.HasIndex(e => e.ApplicantId, "indx_BackToPrRequest_ApplicantId").HasFillFactor(90);

            entity.HasIndex(e => new { e.ApplicantId, e.StatusFlag }, "indx_BackToPrRequest_ApplicantId_StatusFlag").HasFillFactor(90);

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankAcc>(entity =>
        {
            entity.ToTable("BankAcc");

            entity.Property(e => e.AccHolder).HasMaxLength(800);
            entity.Property(e => e.AccNo).HasMaxLength(300);
            entity.Property(e => e.AccType).HasMaxLength(300);
            entity.Property(e => e.ActCode).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Branch)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BankApi>(entity =>
        {
            entity.ToTable("BankApi");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2019>(entity =>
        {
            entity.ToTable("BankApi2019", tb => tb.HasTrigger("InsertORMultiEntry"));

            entity.HasIndex(e => e.Id, "IX_BankApi2019").IsUnique();

            entity.HasIndex(e => e.TransectionId, "uTransId").IsUnique();

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2020>(entity =>
        {
            entity.ToTable("BankApi2020", tb => tb.HasTrigger("InsertORMultiEntry20"));

            entity.HasIndex(e => e.TransectionId, "UQ__BankApi2__6FA95713CC887AED").IsUnique();

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2021>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("BankApi2021", tb => tb.HasTrigger("InsertORMultiEntry21"));

            entity.HasIndex(e => e.ErpStatus, "ErpStatus_BankApi2021_Idx");

            entity.HasIndex(e => e.TransectionId, "UQ__BankApi2__6FA9571330078866")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2022>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_BankApi2022_New")
                .HasFillFactor(90);

            entity.ToTable("BankApi2022", tb => tb.HasTrigger("InsertORMultiEntry22New"));

            entity.HasIndex(e => e.CreateDate, "Idx_CreateDate_NonClustered_New");

            entity.HasIndex(e => e.ErpStatus, "Idx_ErpStatus_NonClustered_New");

            entity.HasIndex(e => e.FprId, "Idx_Fprid_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => new { e.PolicyId, e.ErpStatus }, "InsuranceDB_SQLOPS_BankApi2022_2329038_2329037");

            entity.HasIndex(e => e.TransectionId, "UQ__BankApi2__6FA95713E08F78AF")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2022Old>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_BankApi2022")
                .HasFillFactor(90);

            entity.ToTable("BankApi2022_Old", tb => tb.HasTrigger("InsertORMultiEntry22"));

            entity.HasIndex(e => e.CreateDate, "Idx_CreateDate_NonClustered");

            entity.HasIndex(e => e.ErpStatus, "Idx_ErpStatus_NonClustered");

            entity.HasIndex(e => e.FprId, "Idx_Fprid_NonClustered");

            entity.HasIndex(e => e.TransectionId, "UQ__BankApi2__6FA9571305DF964D")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2023>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("BankApi2023", tb => tb.HasTrigger("InsertORMultiEntry23"));

            entity.HasIndex(e => e.TransectionId, "UQ__BankApi2__6FA957130D24638B")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.ErpStatus, "indx_BankApi2023_erp_status");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2024>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("BankApi2024");

            entity.HasIndex(e => e.TransectionId, "UQ__BankApi20246FA957130D24638B")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.ErpStatus, "indx_erp_status_2024").HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayApiid).HasColumnName("PayAPIID");
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankApi2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("BankAPI2025");

            entity.HasIndex(e => e.TransectionId, "UQ_BankAPI2025")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.ErpStatus, "indx_erp_status_2025").HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayApiid).HasColumnName("PayAPIID");
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<BankBranch>(entity =>
        {
            entity.ToTable("BankBranch");

            entity.Property(e => e.BankBranchCode).HasMaxLength(50);
            entity.Property(e => e.BankBranchName).HasMaxLength(100);
            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankCustomSm>(entity =>
        {
            entity.HasKey(e => e.ConId);

            entity.Property(e => e.AccNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.TranType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BankFlowSetting>(entity =>
        {
            entity.ToTable("BankFlowSetting");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<BankInfoUpdate>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("BankInfoUpdate");

            entity.Property(e => e.AssignDate).HasColumnType("datetime");
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.RoutingNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankInfoUpdateUser>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("BankInfoUpdateUser");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(1);
        });

        modelBuilder.Entity<BankMain>(entity =>
        {
            entity.ToTable("BankMain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankName).HasMaxLength(800);
        });

        modelBuilder.Entity<BannerManagement>(entity =>
        {
            entity.HasKey(e => e.BannerId);

            entity.ToTable("BannerManagement");

            entity.Property(e => e.BannerId).HasColumnName("BannerID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ImgName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BgmeaworkerList>(entity =>
        {
            entity.ToTable("BGMEAWorkerList");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfJoining)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.GtliId).HasColumnName("GtliID");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDNumber");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SlNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BlockSpUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.LastUpdate, "LastUpdate_BlockSpUsers_Idx");

            entity.HasIndex(e => e.Spname, "SPName_BlockSpUsers_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.UserName, "UserName_BlockSpUsers_Idx").HasFillFactor(90);

            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Spname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SPName");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BonusCalculation>(entity =>
        {
            entity.HasKey(e => e.BonusCalcId).HasFillFactor(90);

            entity.ToTable("BonusCalculation");

            entity.Property(e => e.BonusCalcId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BonusAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.BonusStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RevDetailId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<BonusDetails16>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("BonusDetails_16");

            entity.HasIndex(e => e.Fprid, "FprId_BonusDetails_16_Idx").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.NthYr).HasColumnName("nthYr");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.YrlyTotPrem).HasColumnName("yrlyTotPrem");
        });

        modelBuilder.Entity<BonusDetails1622>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("BonusDetails_16_22");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.NthYr).HasColumnName("nthYr");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.YrlyTotPrem).HasColumnName("yrlyTotPrem");
        });

        modelBuilder.Entity<BonusDetails16new>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("BonusDetails_16New");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.NthYr).HasColumnName("nthYr");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.YrlyTotPrem).HasColumnName("yrlyTotPrem");
        });

        modelBuilder.Entity<BonusMaster>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("Bonus_Master");

            entity.HasIndex(e => e.Fprid, "Fprid_Bonus_Master_Idx").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BonusMaster22>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Bonus_Master_22");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BonusPoliciesByYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BonusPoliciesByYear2020");

            entity.ToTable("BonusPoliciesByYear");

            entity.HasIndex(e => e.BonusAmt, "BonusAmt_BonusPoliciesByYear_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.Fprid, "FprId_BonusPoliciesByYear_Idx").HasFillFactor(90);

            entity.Property(e => e.Fprid).HasColumnName("fprid");
            entity.Property(e => e.PrevStatas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Statas).HasMaxLength(50);
            entity.Property(e => e.StatasEighteen).HasMaxLength(50);
        });

        modelBuilder.Entity<BonusRate>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BonusRate1).HasColumnName("BonusRate");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RelationId).HasDefaultValue(0);
            entity.Property(e => e.Status).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BonusRevDetail>(entity =>
        {
            entity.HasKey(e => e.RevDetailId);

            entity.Property(e => e.RevDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BonusAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.RevId).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<BonusRevMaster>(entity =>
        {
            entity.HasKey(e => e.RevId);

            entity.ToTable("BonusRevMaster");

            entity.Property(e => e.RevId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Descrip)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.RevName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BonusYrlyDeathBenRate>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Bonus_yrlyDeathBenRate");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .IsUnicode(false)
                .HasColumnName("createBy");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.RelationId).HasDefaultValue(0);
            entity.Property(e => e.Status).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BonusYrlyMngExp>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Bonus_yrlyMngExp");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .IsUnicode(false)
                .HasColumnName("createBy");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.NthYear).HasColumnName("nthYear");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RelationId).HasDefaultValue(0);
            entity.Property(e => e.Status).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BranchLandLordInfo>(entity =>
        {
            entity.HasKey(e => e.SlNo);

            entity.ToTable("BranchLandLordInfo");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LandLordBankAccNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LandLordBankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LandLordContractDoc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LandLordMobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LandLordName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LandLordNic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LandLordNIC");
            entity.Property(e => e.LandLordNicdoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LandLordNICDoc");
        });

        modelBuilder.Entity<BranchMonthlyTarget>(entity =>
        {
            entity.HasKey(e => e.TargetId);

            entity.ToTable("BranchMonthlyTarget");

            entity.Property(e => e.TargetId).HasColumnName("TargetID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TargetMonth)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BranchRentUtility>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.HasIndex(e => e.BranchId, "BranchId_BranchRentUtilities").HasFillFactor(90);

            entity.HasIndex(e => e.MonthCount, "MonthCount_BranchRentUtilities").HasFillFactor(90);

            entity.HasIndex(e => e.Year, "Year_BranchRentUtilities");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Memo).IsUnicode(false);
            entity.Property(e => e.MonthName).IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BranchUtility>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Memo).IsUnicode(false);
            entity.Property(e => e.MonthName).IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UtilityType).IsUnicode(false);
        });

        modelBuilder.Entity<BranchYearlyTarget>(entity =>
        {
            entity.HasKey(e => e.TargetId);

            entity.ToTable("BranchYearlyTarget");

            entity.Property(e => e.TargetId).HasColumnName("TargetID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BudgetTbl>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("BudgetTbl");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Avrg).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Change).HasColumnType("money");
            entity.Property(e => e.CurYrAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ForecastAmt).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Median).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.PrevYrAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PrevYrLessAmt).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CallManage2021>(entity =>
        {
            entity.ToTable("CallManage2021");

            entity.Property(e => e.AgentCall).HasDefaultValue(0);
            entity.Property(e => e.CallCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CallEnd).HasColumnType("datetime");
            entity.Property(e => e.CallStart).HasColumnType("datetime");
            entity.Property(e => e.CallUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CallManage2022>(entity =>
        {
            entity.ToTable("CallManage2022");

            entity.Property(e => e.AgentCall).HasDefaultValue(0);
            entity.Property(e => e.CallCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CallEnd).HasColumnType("datetime");
            entity.Property(e => e.CallStart).HasColumnType("datetime");
            entity.Property(e => e.CallUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CallManage2023>(entity =>
        {
            entity.ToTable("CallManage2023");

            entity.HasIndex(e => new { e.CallUser, e.StatusFlag }, "indx_CallManage2023_CallUser_StatusFlag");

            entity.HasIndex(e => new { e.FprId, e.StatusFlag, e.Id }, "indx_CallManage2023_FprId_StatusFlag_Id").HasFillFactor(90);

            entity.HasIndex(e => e.StatusFlag, "indx_CallManage2023_StatusFlag");

            entity.Property(e => e.AgentCall).HasDefaultValue(0);
            entity.Property(e => e.CallCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CallEnd).HasColumnType("datetime");
            entity.Property(e => e.CallStart).HasColumnType("datetime");
            entity.Property(e => e.CallUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CallManage2024>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("CallManage2024");

            entity.HasIndex(e => new { e.CallUser, e.StatusFlag }, "indx_CallUser_StatusFlag_2024").HasFillFactor(90);

            entity.HasIndex(e => new { e.FprId, e.StatusFlag, e.Id }, "indx_FprId_StatusFlag_Id_2024").HasFillFactor(90);

            entity.HasIndex(e => e.StatusFlag, "indx_StatusFlag_2024").HasFillFactor(90);

            entity.Property(e => e.AgentCall).HasDefaultValue(0);
            entity.Property(e => e.CallCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CallEnd).HasColumnType("datetime");
            entity.Property(e => e.CallStart).HasColumnType("datetime");
            entity.Property(e => e.CallUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CallManage2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("CallManage2025");

            entity.HasIndex(e => new { e.CallUser, e.StatusFlag }, "indx_CallUser_StatusFlag_2025").HasFillFactor(90);

            entity.HasIndex(e => new { e.FprId, e.StatusFlag, e.Id }, "indx_FprId_StatusFlag_Id_2025").HasFillFactor(90);

            entity.HasIndex(e => e.StatusFlag, "indx_StatusFlag_2025").HasFillFactor(90);

            entity.Property(e => e.AgentCall).HasDefaultValue(0);
            entity.Property(e => e.CallCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CallEnd).HasColumnType("datetime");
            entity.Property(e => e.CallStart).HasColumnType("datetime");
            entity.Property(e => e.CallUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CallManageTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("CallManageTemp");

            entity.HasIndex(e => e.FprId, "unkFprId")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CallCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CallUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
        });

        modelBuilder.Entity<CallUser>(entity =>
        {
            entity.ToTable("CallUser");

            entity.Property(e => e.CallUser1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CallUser");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EnableCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CbsilconsolidatedCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CBSILConsolidatedCustomer");

            entity.Property(e => e.AccStatement).HasMaxLength(255);
            entity.Property(e => e.ActCode).HasMaxLength(255);
            entity.Property(e => e.ActName).HasMaxLength(255);
            entity.Property(e => e.Camount).HasColumnName("CAmount");
            entity.Property(e => e.CreateDate).HasMaxLength(255);
            entity.Property(e => e.Damount).HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasMaxLength(255);
            entity.Property(e => e.DelUser).HasMaxLength(255);
            entity.Property(e => e.Descrp).HasMaxLength(255);
            entity.Property(e => e.EntryDate).HasMaxLength(255);
            entity.Property(e => e.FromActCode).HasMaxLength(255);
            entity.Property(e => e.ToActCode).HasMaxLength(255);
            entity.Property(e => e.UserId).HasMaxLength(255);
            entity.Property(e => e.VoucherNo).HasMaxLength(255);
        });

        modelBuilder.Entity<ChangeHistory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__ChangeHi__3214EC27A4A955AD")
                .HasFillFactor(90);

            entity.ToTable("ChangeHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChatRoom>(entity =>
        {
            entity.ToTable("ChatRoom");

            entity.Property(e => e.ChatText).HasMaxLength(500);
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReadBy)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChatRoom1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ChatRooms");

            entity.ToTable("ChatRooms");

            entity.HasIndex(e => e.ReadStatus, "ReadStatus_ChatRooms_Idx");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.GroupId).HasDefaultValue(0);
        });

        modelBuilder.Entity<ChatRoomGroup>(entity =>
        {
            entity.ToTable("ChatRoomGroup");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.GroupName).IsUnicode(false);
        });

        modelBuilder.Entity<ChatRoomGroupUser>(entity =>
        {
            entity.ToTable("ChatRoomGroupUser");

            entity.Property(e => e.ReadStatus).HasDefaultValue(0);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CheckInOut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckInOut");

            entity.Property(e => e.CheckTime).HasColumnType("datetime");
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Cic>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("CIC");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Circular>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Circular");

            entity.Property(e => e.CircularDetails)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.CircularTitle)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Docs)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CircularDetail>(entity =>
        {
            entity.Property(e => e.CircularDetails).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Deadline).HasColumnType("datetime");
            entity.Property(e => e.UploadDocs).IsUnicode(false);
        });

        modelBuilder.Entity<CircularMaster>(entity =>
        {
            entity.ToTable("CircularMaster");

            entity.Property(e => e.CircularDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).IsUnicode(false);
        });

        modelBuilder.Entity<ClaimCourt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClaimCourt");

            entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClaimDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimNotificationDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimStatus).HasMaxLength(100);
            entity.Property(e => e.ClaimType).HasMaxLength(100);
            entity.Property(e => e.CommencementDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DecisionDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OcfreceivingDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCFreceivingDate");
            entity.Property(e => e.PaidDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNo).HasMaxLength(100);
        });

        modelBuilder.Entity<ClaimFileAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ClaimFileAllocation");

            entity.Property(e => e.ClaimType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.InsNo).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClaimFileIn>(entity =>
        {
            entity.HasKey(e => e.InId);

            entity.ToTable("ClaimFileIn");

            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.InBy).HasMaxLength(100);
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.SubmittedTo).HasMaxLength(100);
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClaimFileRequisition>(entity =>
        {
            entity.HasKey(e => e.ReqId).HasFillFactor(90);

            entity.ToTable("ClaimFileRequisition");

            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.RequisitionTo).HasMaxLength(100);
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClaimInvestigation>(entity =>
        {
            entity.ToTable("ClaimInvestigation");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IntervieweeAddress).IsUnicode(false);
            entity.Property(e => e.IntervieweeComments).IsUnicode(false);
            entity.Property(e => e.IntervieweeContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IntervieweeName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimMaster>(entity =>
        {
            entity.HasKey(e => e.ClaimId).HasFillFactor(90);

            entity.ToTable("ClaimMaster", tb => tb.HasTrigger("TR_ClaimMaster_InsertUpdate_UMP_Claim_API_JSON"));

            entity.HasIndex(e => e.Flag, "Flag_ClaimMaster_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.PolicyNo, "PolicyNo_ClaimMaster_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.Flag, "indx_ClaimMaster_Flag");

            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AllDiagnosticsPaper)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ampm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMPM");
            entity.Property(e => e.AwaitingDeptId).HasColumnName("AwaitingDeptID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CauseOfDeath).IsUnicode(false);
            entity.Property(e => e.CemeteryCertificate).IsUnicode(false);
            entity.Property(e => e.CemeteryId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimIdNoChar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CoversUp)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeathCertByDocId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DeathCertByDocID");
            entity.Property(e => e.DeathCertificatebyDoctor).IsUnicode(false);
            entity.Property(e => e.DeathComments).IsUnicode(false);
            entity.Property(e => e.DeathPlace)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EpacicbillForHospital)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EPACICBillForHospital");
            entity.Property(e => e.EpacicxrayReport)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EPACICXRayReport");
            entity.Property(e => e.Fcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCID");
            entity.Property(e => e.FirDoc).IsUnicode(false);
            entity.Property(e => e.FirDocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirdocumentDate).HasColumnName("FIRDocumentDate");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.ForeignClearanceCert).IsUnicode(false);
            entity.Property(e => e.HospitalOrDocName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HospitalOrDoctorAddress).IsUnicode(false);
            entity.Property(e => e.IsAlterationDone).HasColumnName("isAlterationDone");
            entity.Property(e => e.IsNeedToAlter).HasColumnName("isNeedToAlter");
            entity.Property(e => e.IsPostAuditDone).HasColumnName("isPostAuditDone");
            entity.Property(e => e.IsPreAuditDone).HasColumnName("isPreAuditDone");
            entity.Property(e => e.IsSentToPreAudit).HasColumnName("isSentToPreAudit");
            entity.Property(e => e.LocalGovtAuthorityCert).IsUnicode(false);
            entity.Property(e => e.LocalGovtId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NeedToAlterProposedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NeedToAlterProposedDate).HasColumnType("datetime");
            entity.Property(e => e.NomineeDoc).IsUnicode(false);
            entity.Property(e => e.NomineeDocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Photograph)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostMortemDoc).IsUnicode(false);
            entity.Property(e => e.PostMortemDocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReinsComment).IsUnicode(false);
            entity.Property(e => e.ReinsPayDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReinsStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Smsflag)
                .HasDefaultValue(0)
                .HasColumnName("SMSFlag");
            entity.Property(e => e.SpecificReasonofDeath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StateofAffair)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StatusOnClaimDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SupCauseOfDeathAccident)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupDateOfIncident)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupDateOfNotificationToOrganization)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupHour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupMinute)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupPlaceOfIncident)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SuppTypesOfClaim)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnsettledComments).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.WaiverCertificate)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimMasterStatus>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("ClaimMasterStatus");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Status).IsUnicode(false);
        });

        modelBuilder.Entity<ClaimRegister>(entity =>
        {
            entity.HasKey(e => e.ClmRegId).HasFillFactor(90);

            entity.ToTable("ClaimRegister");

            entity.HasIndex(e => new { e.ClaimId, e.Fprid }, "indx_ClaimRegister_ClaimID_FPRID");

            entity.Property(e => e.ClmRegId).HasColumnName("ClmRegID");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimRegisterTmp>(entity =>
        {
            entity.ToTable("ClaimRegisterTMP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimSettlement>(entity =>
        {
            entity.HasKey(e => e.ClaimSettlementId).HasFillFactor(90);

            entity.ToTable("ClaimSettlement");

            entity.HasIndex(e => e.ClaimId, "ClaimId_ClaimSettlement_Idx");

            entity.HasIndex(e => e.PolicyId, "PolicyId_ClaimSettlement_Idx").HasFillFactor(90);

            entity.Property(e => e.ClaimComMemberName).IsUnicode(false);
            entity.Property(e => e.ClaimSummary).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DecisionofClaimCommittee).IsUnicode(false);
            entity.Property(e => e.InvestigationSummary).IsUnicode(false);
        });

        modelBuilder.Entity<ClaimSettlementFromMail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__ClaimSet__3214EC271F2BA5D7")
                .HasFillFactor(90);

            entity.ToTable("ClaimSettlementFromMail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ClaimStagePaymentList>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("ClaimStagePaymentList", tb => tb.HasTrigger("TR_ClaimMaster_InsertUpdate_UMP_Stipend_Maturity_API_JSON"));

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Cmonths).IsUnicode(false);
            entity.Property(e => e.Cyr).HasColumnName("CYr");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClaimType>(entity =>
        {
            entity.ToTable("ClaimType");

            entity.Property(e => e.ClaimTypeName).IsUnicode(false);
        });

        modelBuilder.Entity<CollectionReversedNagad2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CollectionReversedNagad_2023");

            entity.Property(e => e.TrxnId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TrxnID");
            entity.Property(e => e.Vno)
                .HasMaxLength(4000)
                .HasColumnName("VNO");
        });

        modelBuilder.Entity<ComPayTbl>(entity =>
        {
            entity.ToTable("ComPayTbl");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BC");
            entity.Property(e => e.Bm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BM");
            entity.Property(e => e.Dc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DC");
            entity.Property(e => e.Dvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVC");
            entity.Property(e => e.Fa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FA");
            entity.Property(e => e.Pol)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pr");
            entity.Property(e => e.Rc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RC");
            entity.Property(e => e.TotalPaid).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UM");
            entity.Property(e => e.Unpaid).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ComPayTmp>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("ComPayTmp");

            entity.Property(e => e.Sl).HasColumnName("sl");
            entity.Property(e => e.AgentType).HasMaxLength(50);
            entity.Property(e => e.Agentid)
                .HasMaxLength(50)
                .HasColumnName("agentid");
            entity.Property(e => e.Ait)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ait");
            entity.Property(e => e.BankAcc).HasMaxLength(50);
            entity.Property(e => e.BasicCom)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("basicCom");
            entity.Property(e => e.Paydt)
                .HasColumnType("smalldatetime")
                .HasColumnName("paydt");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Pf).HasColumnName("pf");
            entity.Property(e => e.Policyid)
                .HasMaxLength(50)
                .HasColumnName("policyid");
            entity.Property(e => e.Prid)
                .HasMaxLength(50)
                .HasColumnName("prid");
            entity.Property(e => e.SupCom)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("supCom");
            entity.Property(e => e.Userid)
                .HasMaxLength(500)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<ComProblem2207T5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ComProblem2207_T5");

            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.Orentryid).HasColumnName("ORENTRYID");
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.PaymentPurpose)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ComVatRptTbl>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("ComVatRptTbl");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BmAit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bmAit");
            entity.Property(e => e.BmCom)
                .HasColumnType("money")
                .HasColumnName("bmCom");
            entity.Property(e => e.Bmname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BMNAME");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FaAit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("faAit");
            entity.Property(e => e.FaCom)
                .HasColumnType("money")
                .HasColumnName("faCom");
            entity.Property(e => e.FaName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("faNAME");
            entity.Property(e => e.Fprid)
                .IsUnicode(false)
                .HasColumnName("FPRID");
            entity.Property(e => e.Npdd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("npdd");
            entity.Property(e => e.OrEntryId).HasColumnName("OrEntryID");
            entity.Property(e => e.SamdName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("samdNAME");
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.SumAssured).HasColumnType("money");
            entity.Property(e => e.TotalAit).HasColumnType("money");
            entity.Property(e => e.TotalCommission).HasColumnType("money");
            entity.Property(e => e.TotalPremiumAmount).HasColumnType("money");
            entity.Property(e => e.Type).IsUnicode(false);
            entity.Property(e => e.UmAit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("umAit");
            entity.Property(e => e.UmCom)
                .HasColumnType("money")
                .HasColumnName("umCom");
            entity.Property(e => e.UmName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("umNAME");
        });

        modelBuilder.Entity<ComVatRptTbl4>(entity =>
        {
            entity.HasKey(e => e.Sl)
                .HasName("PK_ComVatRptTbl2")
                .HasFillFactor(90);

            entity.ToTable("ComVatRptTbl4");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BmAit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("bmAit");
            entity.Property(e => e.BmCom)
                .HasColumnType("money")
                .HasColumnName("bmCom");
            entity.Property(e => e.Bmname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BMNAME");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FaAit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("faAit");
            entity.Property(e => e.FaCom)
                .HasColumnType("money")
                .HasColumnName("faCom");
            entity.Property(e => e.FaName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("faNAME");
            entity.Property(e => e.Fprid)
                .IsUnicode(false)
                .HasColumnName("FPRID");
            entity.Property(e => e.Npdd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("npdd");
            entity.Property(e => e.OrEntryId).HasColumnName("OrEntryID");
            entity.Property(e => e.SamdName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("samdNAME");
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.SumAssured).HasColumnType("money");
            entity.Property(e => e.TotalAit).HasColumnType("money");
            entity.Property(e => e.TotalCommission).HasColumnType("money");
            entity.Property(e => e.TotalPremiumAmount).HasColumnType("money");
            entity.Property(e => e.Type).IsUnicode(false);
            entity.Property(e => e.UmAit)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("umAit");
            entity.Property(e => e.UmCom)
                .HasColumnType("money")
                .HasColumnName("umCom");
            entity.Property(e => e.UmName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("umNAME");
        });

        modelBuilder.Entity<CommissionRateChart>(entity =>
        {
            entity.ToTable("CommissionRateChart", "Expenses");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Agm).HasColumnName("AGM");
            entity.Property(e => e.Bm1).HasColumnName("BM1");
            entity.Property(e => e.Dgm).HasColumnName("DGM");
            entity.Property(e => e.Fa).HasColumnName("FA");
            entity.Property(e => e.Gm).HasColumnName("GM");
            entity.Property(e => e.TermOfYear)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Um1).HasColumnName("UM1");
        });

        modelBuilder.Entity<Compf>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("compf");

            entity.Property(e => e.Sl).HasColumnName("sl");
            entity.Property(e => e.Agent)
                .HasMaxLength(50)
                .HasColumnName("agent");
            entity.Property(e => e.Done).HasColumnName("done");
            entity.Property(e => e.Fpr)
                .HasMaxLength(50)
                .HasColumnName("fpr");
            entity.Property(e => e.Pf).HasColumnName("pf");
            entity.Property(e => e.Pr)
                .HasMaxLength(50)
                .HasColumnName("pr");
        });

        modelBuilder.Entity<Complain>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Complain");

            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.ResolvedBy).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Contact_us");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Details)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CountMaxIdtable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Count_Ma__3214EC2755024493");

            entity.ToTable("Count_MaxIDTable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BeforeAfter)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Before_After");
            entity.Property(e => e.DateTimeRecorded).HasColumnType("datetime");
            entity.Property(e => e.MaxId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MaxID");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CountryCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("CountryCode");

            entity.Property(e => e.CodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CourierCompanyList>(entity =>
        {
            entity.HasKey(e => e.CourierId);

            entity.ToTable("CourierCompanyList");

            entity.Property(e => e.CourierId).HasColumnName("CourierID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CourierCompanyName).IsUnicode(false);
        });

        modelBuilder.Entity<CourierServiceSetup>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("CourierServiceSetup");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CourierAddress).IsUnicode(false);
            entity.Property(e => e.CourierContactNo).IsUnicode(false);
            entity.Property(e => e.CourierEmail).IsUnicode(false);
            entity.Property(e => e.CourierName).IsUnicode(false);
            entity.Property(e => e.CourierWebsite).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DailyCashTransaction2021>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DailyCashTransaction2021");

            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.TxDate).HasColumnType("datetime");
            entity.Property(e => e.TxType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DailyCashTransaction2022>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DailyCashTransaction2022");

            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.TxDate).HasColumnType("datetime");
            entity.Property(e => e.TxType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DailyCashTransaction2023>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DailyCashTransaction2023");

            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.TxDate).HasColumnType("datetime");
            entity.Property(e => e.TxType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DailyCashTransaction2024>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DailyCashTransaction2024");

            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.TxDate).HasColumnType("datetime");
            entity.Property(e => e.TxType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DailyCashTransaction2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DailyCashTransaction2025");

            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.TxDate).HasColumnType("datetime");
            entity.Property(e => e.TxType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DailyExpense>(entity =>
        {
            entity.HasKey(e => e.ExpId);

            entity.ToTable("DailyExpense");

            entity.HasIndex(e => e.ExpDate, "ExpDate_DailyExpense");

            entity.Property(e => e.ExpId).HasColumnName("ExpID");
            entity.Property(e => e.AgentId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Branch).IsUnicode(false);
            entity.Property(e => e.Chq)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ExpTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExpTypeID");
            entity.Property(e => e.ExpTypeName).IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeathClaimOthersDocument>(entity =>
        {
            entity.ToTable("DeathClaimOthersDocument");

            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentName).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DelAccgl2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("delAccgl2022");

            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus).HasMaxLength(50);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy).HasMaxLength(50);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("datetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance).HasMaxLength(10);
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<DelApplicant2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DelApplicant2024");

            entity.Property(e => e.Acc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AncestralDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentName).IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantId).ValueGeneratedOnAdd();
            entity.Property(e => e.ApplicantIdno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ApplicantIDNo");
            entity.Property(e => e.ApplicantMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantNameBang).HasMaxLength(500);
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPhotoName).IsUnicode(false);
            entity.Property(e => e.ApplicantPpname)
                .IsUnicode(false)
                .HasColumnName("ApplicantPPName");
            entity.Property(e => e.ApplicantSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlace).IsUnicode(false);
            entity.Property(e => e.ChestSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPoxVaccin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentHeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentWeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentlyWell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EduQualification).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EpilepticProblem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EyeDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FrequentCough)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GoitrousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificationMark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InfectiousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LongHolidayForIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiltDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PhysicalDisability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderSignature).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SmsFormate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StomachInfection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SummeryCommentBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SummeryCommentDate).HasColumnType("datetime");
            entity.Property(e => e.TypesOfOperation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnderWrittingComments).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UploadDocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UploadDocumentID");
            entity.Property(e => e.UrineStone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uwcomments)
                .IsUnicode(false)
                .HasColumnName("UWComments");
            entity.Property(e => e.Uwstatus).HasColumnName("UWStatus");
            entity.Property(e => e.WaistSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeightLossOrGain)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenBaby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEarnAbility)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEduQualification).IsUnicode(false);
            entity.Property(e => e.WomenHusbandMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandName)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKids)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKidsExpectation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenLastPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenPayTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenSourceOfIncome)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeletedVoucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DeletedVoucher");

            entity.Property(e => e.VoucherNo).HasMaxLength(255);
        });

        modelBuilder.Entity<DepreDetail>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AssetName).IsUnicode(false);
            entity.Property(e => e.CumulativeDep).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DepAmt).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.DepPerc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MotorName).IsUnicode(false);
            entity.Property(e => e.RegNo).IsUnicode(false);
            entity.Property(e => e.ValueRemain).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<DepreciationDetail>(entity =>
        {
            entity.ToTable("DepreciationDetail");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<DevAdminApproval>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DevAdminApproval");

            entity.Property(e => e.AcademicFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgentFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgentJobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Agent_Job_Status");
            entity.Property(e => e.AgentMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AgentSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankAcno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BankACNo");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChangeType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurOccupation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DiscontinueReason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EduQualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EduUploadFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.GuardianAge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GuardianRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NidFileName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NidpassNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIDPassNo");
            entity.Property(e => e.NomineeAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAge)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Ref1Address).IsUnicode(false);
            entity.Property(e => e.Ref1MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref1Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ref1Occcupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref2Address).IsUnicode(false);
            entity.Property(e => e.Ref2MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ref2Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ref2Occcupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoutingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TINNo");
            entity.Property(e => e.UnitOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Disbursement>(entity =>
        {
            entity.ToTable("Disbursement", "kiosk");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TransactionID");
        });

        modelBuilder.Entity<Dismemberment>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Dismemberment");

            entity.Property(e => e.Sl)
                .ValueGeneratedNever()
                .HasColumnName("SL");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DispatchDetail>(entity =>
        {
            entity.HasKey(e => e.DispatchId);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.DispatchCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DispatchType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DispatchedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiverAddress).IsUnicode(false);
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SenderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrackNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DispatchIn>(entity =>
        {
            entity.HasKey(e => e.DispatchInId).HasFillFactor(90);

            entity.ToTable("DispatchIn");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.ReceivedFor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SenderName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DispatchOption>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_DespatchDeliveryOptions");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OptionName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DispatchOut>(entity =>
        {
            entity.HasKey(e => e.DispatchId);

            entity.ToTable("DispatchOut");

            entity.Property(e => e.CourierCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CourierTrackNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.DispatchOption)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DispatchType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DispatchedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrivilegeCard)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiverAddress).IsUnicode(false);
            entity.Property(e => e.ReceiverEmployeeType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SenderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DispatchPurpose>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("DispatchPurpose");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Purpose)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DistrictList>(entity =>
        {
            entity.ToTable("DistrictList");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistrictName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ditclacc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DITCLAcc");

            entity.Property(e => e.ActCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ActName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Camount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Damount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Df)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("df");
            entity.Property(e => e.Dt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dt");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.NewName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DividendDetail>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Ait).HasMaxLength(50);
            entity.Property(e => e.BankAc).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Brokerage).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CashPer).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.FaceValue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SharePer).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShareQty).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShareRate).HasColumnType("money");
        });

        modelBuilder.Entity<DivisionList>(entity =>
        {
            entity.ToTable("DivisionList");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DivisionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocIdChangeHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DocIdChangeHistory");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.NewDoeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldDocId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocumentList>(entity =>
        {
            entity.ToTable("DocumentList", "kiosk");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Blobfile)
                .IsUnicode(false)
                .HasColumnName("BLOBFile");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            entity.Property(e => e.PolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.ToTable("DocumentTypes", "kiosk");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DocumentTypeName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DocumentTypeNameBng)
                .HasMaxLength(300)
                .HasColumnName("DocumentTypeNameBNG");
        });

        modelBuilder.Entity<Dprrate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DPRRate");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Female)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Male)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("DPR");
        });

        modelBuilder.Entity<DpsChange>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DpsChange");

            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameNew)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameOld)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DpsScheme>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("DPS_Scheme");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActiveStatus).HasMaxLength(50);
            entity.Property(e => e.BankId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepoFreq)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Depo_Freq");
            entity.Property(e => e.DisableBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisableDateTime).HasColumnType("datetime");
            entity.Property(e => e.DpsAmt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("DPS_Amt");
            entity.Property(e => e.DpsNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DPS_No");
            entity.Property(e => e.InstallmentAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MaturityAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SchemeType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DpsSchemeC>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("DPS_SchemeC");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActiveStatus).HasMaxLength(50);
            entity.Property(e => e.BankId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.DepoFreq)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Depo_Freq");
            entity.Property(e => e.DisableBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisableDateTime).HasColumnType("datetime");
            entity.Property(e => e.DpsAmt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("DPS_Amt");
            entity.Property(e => e.DpsNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DPS_No");
            entity.Property(e => e.InstallmentAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MaturityAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SchemeType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dpslist>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__DPSList__3214EC07EEE1DDF3")
                .HasFillFactor(90);

            entity.ToTable("DPSList");

            entity.Property(e => e.AccNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ActiveStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepoFreq)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Depo_Freq");
            entity.Property(e => e.DpsAmt).HasColumnName("DPS_Amt");
            entity.Property(e => e.DpsNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DPS_No");
        });

        modelBuilder.Entity<EditPermissionUser>(entity =>
        {
            entity.ToTable("EditPermissionUser");

            entity.Property(e => e.PagePermission)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("Journal");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EditsAfterChairmanSir>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Edits_After_Chairman_Sir");

            entity.Property(e => e.ActCode).HasMaxLength(255);
            entity.Property(e => e.ActName).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasMaxLength(255);
            entity.Property(e => e.Damount).HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasMaxLength(255);
            entity.Property(e => e.DelUser).HasMaxLength(255);
            entity.Property(e => e.Descrp).HasMaxLength(255);
            entity.Property(e => e.EntryDate).HasMaxLength(255);
            entity.Property(e => e.Sl)
                .HasMaxLength(255)
                .HasColumnName("SL");
            entity.Property(e => e.UserId).HasMaxLength(255);
            entity.Property(e => e.VoucherNo).HasMaxLength(255);
        });

        modelBuilder.Entity<Eftndetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("EFTNDetails");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Eftnstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFTNStatus");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Eftnrecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("EFTNRecord");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActiveStatus).HasMaxLength(50);
            entity.Property(e => e.AgentId).IsUnicode(false);
            entity.Property(e => e.BranchId).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditBank)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreditBankName).IsUnicode(false);
            entity.Property(e => e.CustBank)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustBankAcname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CustBankACName");
            entity.Property(e => e.CustBankAcno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CustBankACNo");
            entity.Property(e => e.CustBankName).IsUnicode(false);
            entity.Property(e => e.EftnstartDate).HasColumnName("EFTNStartDate");
            entity.Property(e => e.LastEftnpaymentDate).HasColumnName("LastEFTNPaymentDate");
            entity.Property(e => e.RoutingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmpAbsent>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("EmpAbsent");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Rfid)
                .HasDefaultValue(0L)
                .HasColumnName("RFID");
        });

        modelBuilder.Entity<EmpAbsentJuly2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmpAbsentJuly2024");

            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Rfid).HasColumnName("RFID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<EmpAttendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId);

            entity.ToTable("EmpAttendance");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
        });

        modelBuilder.Entity<EmpBusinessPerformance>(entity =>
        {
            entity.HasKey(e => e.BusinessId).HasFillFactor(90);

            entity.ToTable("EmpBusinessPerformance");

            entity.HasIndex(e => e.EmpId, "NonClusteredIndex-20200515-152007").HasFillFactor(90);

            entity.HasIndex(e => e.AgentId, "NonClusteredIndex-20200515-152044").HasFillFactor(90);

            entity.Property(e => e.BusinessId).HasColumnName("BusinessID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpChallanDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.BankBranch)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ChallanNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.SalMonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmpDemerit>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DemeritPoints).HasDefaultValue(0.0);
            entity.Property(e => e.NegativeMarks).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EmpDesignationHistory>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("EmpDesignationHistory");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmpErp>(entity =>
        {
            entity.HasKey(e => e.Erpid);

            entity.ToTable("EmpErp");

            entity.Property(e => e.Erpid).HasColumnName("ERPID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Erpapril).HasColumnName("ERPApril");
            entity.Property(e => e.Erpaug).HasColumnName("ERPAug");
            entity.Property(e => e.Erpavg).HasColumnName("ERPAvg");
            entity.Property(e => e.Erpdec).HasColumnName("ERPDec");
            entity.Property(e => e.Erpfeb).HasColumnName("ERPFeb");
            entity.Property(e => e.Erpjan).HasColumnName("ERPJan");
            entity.Property(e => e.Erpjuly).HasColumnName("ERPJuly");
            entity.Property(e => e.Erpjune).HasColumnName("ERPJune");
            entity.Property(e => e.Erpmarch).HasColumnName("ERPMarch");
            entity.Property(e => e.Erpmay).HasColumnName("ERPMay");
            entity.Property(e => e.Erpnov).HasColumnName("ERPNov");
            entity.Property(e => e.Erpoct).HasColumnName("ERPOct");
            entity.Property(e => e.Erpsep).HasColumnName("ERPSep");
        });

        modelBuilder.Entity<EmpGratuity>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("EmpGratuity");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.JobDuration)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JobEndDate).HasColumnName("Job_End_Date");
            entity.Property(e => e.JobStartDate).HasColumnName("Job_Start_Date");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmpIncrement>(entity =>
        {
            entity.HasKey(e => e.IncrementId).HasFillFactor(90);

            entity.ToTable("EmpIncrement");

            entity.Property(e => e.IncrementId).HasColumnName("IncrementID");
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
        });

        modelBuilder.Entity<EmpJobDescription>(entity =>
        {
            entity.HasKey(e => e.JobDescriptionId).HasFillFactor(90);

            entity.ToTable("EmpJobDescription");

            entity.Property(e => e.JobDescriptionId).HasColumnName("JobDescriptionID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.JobDescription).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpJoiningDesignation>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("EmpJoiningDesignation");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmpLapse>(entity =>
        {
            entity.ToTable("EmpLapse");

            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Deptname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpMonthlyPerformance>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("EmpMonthlyPerformance");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Chremarks)
                .IsUnicode(false)
                .HasColumnName("CHRemarks");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.InclineRemarks).IsUnicode(false);
            entity.Property(e => e.InitiativeRemarks).IsUnicode(false);
            entity.Property(e => e.InterpersonalRemarks).IsUnicode(false);
            entity.Property(e => e.LeadershipRemarks).IsUnicode(false);
            entity.Property(e => e.ManagerRemarks).IsUnicode(false);
            entity.Property(e => e.Md).HasColumnName("MD");
            entity.Property(e => e.Mdremarks)
                .IsUnicode(false)
                .HasColumnName("MDRemarks");
            entity.Property(e => e.PlanningRemarks).IsUnicode(false);
            entity.Property(e => e.ProfRoleRemarks).IsUnicode(false);
            entity.Property(e => e.QualityWorkRemarks).IsUnicode(false);
            entity.Property(e => e.TeamWorkRemarks).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpMonthlyperformanceTemp>(entity =>
        {
            entity.ToTable("EmpMonthlyperformanceTemp");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Chremarks)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CHRemarks");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.ManagerRemarks).IsUnicode(false);
            entity.Property(e => e.Md).HasColumnName("MD");
            entity.Property(e => e.Mdremarks)
                .IsUnicode(false)
                .HasColumnName("MDRemarks");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpMovementRegister>(entity =>
        {
            entity.HasKey(e => e.MovementId);

            entity.ToTable("EmpMovementRegister");

            entity.Property(e => e.MovementId).HasColumnName("MovementID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.DesigId).HasColumnName("DesigID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.FromTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WorkType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpOt>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("EmpOT");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Otamount).HasColumnName("OTAmount");
            entity.Property(e => e.Otdate).HasColumnName("OTDate");
        });

        modelBuilder.Entity<EmpPayroll>(entity =>
        {
            entity.HasKey(e => e.PayrollId).HasFillFactor(90);

            entity.ToTable("EmpPayroll");

            entity.HasIndex(e => e.EmpId, "indx_EmpPayroll_EmpID").HasFillFactor(90);

            entity.Property(e => e.PayrollId).HasColumnName("PayrollID");
            entity.Property(e => e.AdvanceDeduct).HasDefaultValue(0.0);
            entity.Property(e => e.AdvanceDeductEmi)
                .HasDefaultValue(0.0)
                .HasColumnName("AdvanceDeductEMI");
            entity.Property(e => e.AdvanceDeductPersonal).HasDefaultValue(0.0);
            entity.Property(e => e.AdvanceDeductPremium).HasDefaultValue(0.0);
            entity.Property(e => e.AdvanceRemain).HasDefaultValue(0.0);
            entity.Property(e => e.AdvanceSalary).HasDefaultValue(0.0);
            entity.Property(e => e.ArrearDescription).IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeductionDescription).IsUnicode(false);
            entity.Property(e => e.DeductionForLate).HasDefaultValue(0.0);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesigId).HasColumnName("DesigID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.LateAttandance).HasDefaultValue(0);
            entity.Property(e => e.LeaveTaken).HasDefaultValue(0);
            entity.Property(e => e.Otamount)
                .HasDefaultValue(0.0)
                .HasColumnName("OTAmount");
            entity.Property(e => e.Otdays)
                .HasDefaultValue(0)
                .HasColumnName("OTDays");
            entity.Property(e => e.PensionScheme).HasDefaultValue(0.0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpRanking>(entity =>
        {
            entity.HasKey(e => e.RankId);

            entity.ToTable("EmpRanking");

            entity.Property(e => e.RankId).HasColumnName("RankID");
            entity.Property(e => e.AttAvg).HasDefaultValue(0.0);
            entity.Property(e => e.BisAvg).HasDefaultValue(0.0);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Erpavg)
                .HasDefaultValue(0.0)
                .HasColumnName("ERPAvg");
            entity.Property(e => e.TaskAvg).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EmpRanking2025>(entity =>
        {
            entity.HasKey(e => e.RankId);

            entity.ToTable("EmpRanking2025");

            entity.Property(e => e.RankId).HasColumnName("RankID");
            entity.Property(e => e.AttAvg).HasDefaultValue(0.0);
            entity.Property(e => e.BisAvg).HasDefaultValue(0.0);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Erpavg)
                .HasDefaultValue(0.0)
                .HasColumnName("ERPAvg");
            entity.Property(e => e.TaskAvg).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EmpTaskDetail>(entity =>
        {
            entity.HasKey(e => e.TaskId);

            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.TaskDetail).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpTaskEvaluation>(entity =>
        {
            entity.HasKey(e => e.TaskId);

            entity.ToTable("EmpTaskEvaluation");

            entity.HasIndex(e => e.EmpId, "EmpId_EmpTaskEvaluation").HasFillFactor(90);

            entity.HasIndex(e => e.TaskDate, "TaskDate_EmpTaskEvaluation");

            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.DesigId).HasColumnName("DesigID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.TaskDetail).IsUnicode(false);
            entity.Property(e => e.TaskDetailDone).IsUnicode(false);
            entity.Property(e => e.TaskDetailNotReq).IsUnicode(false);
            entity.Property(e => e.TaskDone).HasDefaultValue(0);
            entity.Property(e => e.TaskNotDone).HasDefaultValue(0);
            entity.Property(e => e.TaskNotDoneDetail).IsUnicode(false);
            entity.Property(e => e.TotalTask).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<EmployeeDocCheck>(entity =>
        {
            entity.ToTable("EmployeeDocCheck");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeDocumentsMaster>(entity =>
        {
            entity.ToTable("EmployeeDocumentsMaster");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ErrorChecker>(entity =>
        {
            entity.ToTable("ErrorChecker");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.ExTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("exTime");
            entity.Property(e => e.Xx)
                .IsUnicode(false)
                .HasColumnName("xx");
        });

        modelBuilder.Entity<ErrorPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ErrorPayment");

            entity.Property(e => e.ApplicantPolicy).HasColumnName("Applicant/Policy");
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExcludeFromReinsurance>(entity =>
        {
            entity.ToTable("ExcludeFromReinsurance");

            entity.HasIndex(e => e.Fprid, "indx_ExcludeFromReinsurance_FPRID").HasFillFactor(90);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
        });

        modelBuilder.Entity<ExecutiveList>(entity =>
        {
            entity.ToTable("ExecutiveList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EmpName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExpenditureDetail>(entity =>
        {
            entity.HasKey(e => e.ExpEntryId);

            entity.Property(e => e.BankCharge).HasColumnName("Bank_Charge");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CleaningExpenses).HasColumnName("Cleaning_Expenses");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.DevExpenses).HasColumnName("Dev_Expenses");
            entity.Property(e => e.EntertainmentBill).HasColumnName("Entertainment_Bill");
            entity.Property(e => e.MedicalExpenses).HasColumnName("Medical_Expenses");
            entity.Property(e => e.MeetingExpenses).HasColumnName("Meeting_Expenses");
            entity.Property(e => e.MiscellaniesExpenses).HasColumnName("Miscellanies_Expenses");
            entity.Property(e => e.NewspaperBill).HasColumnName("Newspaper_Bill");
            entity.Property(e => e.OfficeExpenses).HasColumnName("Office_Expenses");
            entity.Property(e => e.OfficeStationery).HasColumnName("Office_Stationery");
            entity.Property(e => e.PolicyStamp).HasColumnName("Policy_Stamp");
            entity.Property(e => e.RevenueStamp).HasColumnName("Revenue_Stamp");
            entity.Property(e => e.Tada).HasColumnName("TADA");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.VehicleMaintenance).HasColumnName("Vehicle_Maintenance");
        });

        modelBuilder.Entity<ExpenditureList>(entity =>
        {
            entity.HasKey(e => e.ExpenditureId).HasName("PK_ExpendetureList");

            entity.ToTable("ExpenditureList");

            entity.Property(e => e.ExpenditureId).HasColumnName("ExpenditureID");
            entity.Property(e => e.ExpenditureName).IsUnicode(false);
        });

        modelBuilder.Entity<ExtraContribution>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ExtraContribution");

            entity.Property(e => e.AccVoucher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Fachange>(entity =>
        {
            entity.ToTable("FAchange");

            entity.Property(e => e.ApprovalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaidNew).HasColumnName("FAID_New");
            entity.Property(e => e.FaidOld).HasColumnName("FAID_Old");
            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
        });

        modelBuilder.Entity<FdrdateList>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("FDRDateList");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Dt).HasColumnName("dt");
        });

        modelBuilder.Entity<FileAllocAccess>(entity =>
        {
            entity.ToTable("FileAllocAccess");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeletBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValue(1);
        });

        modelBuilder.Entity<FileAllocTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileAllocTemp");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.FileType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<FileAllocTemp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileAllocTemp2");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.FileType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ForwardingPayDetails2021>(entity =>
        {
            entity.ToTable("ForwardingPayDetails2021");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commence).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.DocImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForwardingPayDetails2022>(entity =>
        {
            entity.ToTable("ForwardingPayDetails2022");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commence).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.DocImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForwardingPayDetails2023>(entity =>
        {
            entity.ToTable("ForwardingPayDetails2023");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commence).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.DocImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForwardingPayDetails2024>(entity =>
        {
            entity.ToTable("ForwardingPayDetails2024");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commence).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.DocImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ForwardingPayDetails2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ForwardingPayDetails2025");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commence).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Details).IsUnicode(false);
            entity.Property(e => e.DocImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Fpr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FPR");

            entity.Property(e => e.Ctr).HasColumnName("ctr");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
        });

        modelBuilder.Entity<Fpr2>(entity =>
        {
            entity.ToTable("FPR2");

            entity.Property(e => e.Ctr).HasColumnName("ctr");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
        });

        modelBuilder.Entity<FprEftn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FprEftn");

            entity.Property(e => e.Fprid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fprid");
        });

        modelBuilder.Entity<FprSummary>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("FprSummary");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FaId).HasColumnName("FaID");
            entity.Property(e => e.Months).IsUnicode(false);
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.Yr)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FprSupplimentryDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.DocId, "DocId_FprSupplimentryDetails").HasFillFactor(90);

            entity.HasIndex(e => e.FprId, "FprId_FprSupplimentryDetails");

            entity.HasIndex(e => e.ReinsRate, "ReinsRate_FprSupplimentryDetails").HasFillFactor(90);

            entity.HasIndex(e => e.SupplimentryId, "SuppId_FprSupplimentryDetails");

            entity.Property(e => e.Age)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimAmount).HasDefaultValue(0.0);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReInsurenceType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReinsSupPremium).HasDefaultValue(0.0);
            entity.Property(e => e.SupReinsAmount).HasDefaultValue(0.0);
            entity.Property(e => e.SupplimentryStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Fprinserted>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("FPRinserted");

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.Admitted)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AmdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMdId");
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Bcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCId");
            entity.Property(e => e.Bmid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCId");
            entity.Property(e => e.DocId).IsUnicode(false);
            entity.Property(e => e.Dvcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCId");
            entity.Property(e => e.ExtraCondition).IsUnicode(false);
            entity.Property(e => e.Faid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Fprdate).HasColumnName("FPRDate");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.InstallmentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).IsUnicode(false);
            entity.Property(e => e.PrBmNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.PsdelDate)
                .HasColumnType("datetime")
                .HasColumnName("PSDelDate");
            entity.Property(e => e.PsdeliveredBy)
                .IsUnicode(false)
                .HasColumnName("PSDeliveredBy");
            entity.Property(e => e.PsdeliveredToAgentId).HasColumnName("PSDeliveredToAgentId");
            entity.Property(e => e.PsdeliveredToEmpId).HasColumnName("PSDeliveredToEmpId");
            entity.Property(e => e.PsdeliveryBranchId).HasColumnName("PSDeliveryBranchId");
            entity.Property(e => e.PsdeliveryFlag).HasColumnName("PSDeliveryFlag");
            entity.Property(e => e.Rcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RCId");
            entity.Property(e => e.Samdid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SGMId");
            entity.Property(e => e.SubPolicyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SurrOptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UmId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GiftInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("GiftInfo");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GrievanceCategory>(entity =>
        {
            entity.ToTable("GrievanceCategory");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.GrievanceCategory1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GrievanceCategory");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GrievanceManagement>(entity =>
        {
            entity.ToTable("GrievanceManagement");

            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ComplainStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QueryBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReferToType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferToUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GrievanceType>(entity =>
        {
            entity.ToTable("GrievanceType");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.GrievanceTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GroupAgentComPayment>(entity =>
        {
            entity.HasKey(e => e.GrpComId);

            entity.ToTable("GroupAgentComPayment", tb => tb.HasTrigger("UpdateGtliSetupFlag_AgentComDel"));

            entity.Property(e => e.GrpComId).HasColumnName("GrpComID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Gtliid).HasColumnName("GTLIID");
        });

        modelBuilder.Entity<GroupCategory>(entity =>
        {
            entity.HasKey(e => e.GroupCatId);

            entity.ToTable("GroupCategory");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.GroupCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<GtliMakeAclaimStatus>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("GtliMakeAClaimStatus");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Status).IsUnicode(false);
        });

        modelBuilder.Entity<GtliPercentFinal>(entity =>
        {
            entity.ToTable("GtliPercentFinal");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apr).HasColumnName("apr");
            entity.Property(e => e.Chq).HasColumnName("chq");
            entity.Property(e => e.Mf).HasColumnName("mf");
            entity.Property(e => e.Mt).HasColumnName("mt");
            entity.Property(e => e.Noti).HasColumnName("noti");
            entity.Property(e => e.Nr).HasColumnName("nr");
            entity.Property(e => e.Ocf).HasColumnName("ocf");
            entity.Property(e => e.Paid).HasColumnName("paid");
            entity.Property(e => e.Rej).HasColumnName("rej");
            entity.Property(e => e.Shopid).HasColumnName("shopid");
            entity.Property(e => e.Typ).HasColumnName("typ");
            entity.Property(e => e.Upro).HasColumnName("upro");
            entity.Property(e => e.Yf).HasColumnName("yf");
            entity.Property(e => e.Yt).HasColumnName("yt");
        });

        modelBuilder.Entity<GtliSetupStatus>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("gtliSetupStatus");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Status).IsUnicode(false);
        });

        modelBuilder.Entity<Gtlialteration>(entity =>
        {
            entity.ToTable("GTLIAlteration");

            entity.Property(e => e.AlterFlag).HasDefaultValue(0);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldGtliSupplementaryId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GtliclaimInterviewee>(entity =>
        {
            entity.HasKey(e => e.IntervieweeId);

            entity.ToTable("GTLIClaimInterviewee");

            entity.Property(e => e.IntervieweeId).ValueGeneratedNever();
            entity.Property(e => e.GtliclaimInvestigationId).HasColumnName("GTLIClaimInvestigationId");
            entity.Property(e => e.Gtliid).HasColumnName("GTLIId");
            entity.Property(e => e.IntervieweeAddress).IsUnicode(false);
            entity.Property(e => e.IntervieweeComments).IsUnicode(false);
            entity.Property(e => e.IntervieweeContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IntervieweeDate).HasColumnType("datetime");
            entity.Property(e => e.IntervieweeName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GtliclaimInvestigation>(entity =>
        {
            entity.HasKey(e => e.GtliclaimInvestigationId).HasFillFactor(90);

            entity.ToTable("GTLIClaimInvestigation");

            entity.Property(e => e.GtliclaimInvestigationId).HasColumnName("GTLIClaimInvestigationId");
            entity.Property(e => e.AttendanceSheet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConcernedPhoto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeathCertificate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpStmtInjury)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmploymentCertificate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Firreport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRReport");
            entity.Property(e => e.Gtliid).HasColumnName("GTLIId");
            entity.Property(e => e.Hiancillarycharges)
                .IsUnicode(false)
                .HasColumnName("HIancillarycharges");
            entity.Property(e => e.HibillofConsultants)
                .IsUnicode(false)
                .HasColumnName("HIBillofConsultants");
            entity.Property(e => e.Hibillofmedicine)
                .IsUnicode(false)
                .HasColumnName("HIBillofmedicine");
            entity.Property(e => e.Hicbc)
                .IsUnicode(false)
                .HasColumnName("HICBC");
            entity.Property(e => e.Hidischargecertificate)
                .IsUnicode(false)
                .HasColumnName("HIDischargecertificate");
            entity.Property(e => e.HiemploymentCertificate)
                .IsUnicode(false)
                .HasColumnName("HIEmploymentCertificate");
            entity.Property(e => e.Hihospitalizationrecommendation)
                .IsUnicode(false)
                .HasColumnName("HIhospitalizationrecommendation");
            entity.Property(e => e.Hihospitalized)
                .IsUnicode(false)
                .HasColumnName("HIhospitalized");
            entity.Property(e => e.HiroomCharges)
                .IsUnicode(false)
                .HasColumnName("HIRoomCharges");
            entity.Property(e => e.HisurgicalOperationcharges)
                .IsUnicode(false)
                .HasColumnName("HISurgicalOperationcharges");
            entity.Property(e => e.Hiultrasonography)
                .IsUnicode(false)
                .HasColumnName("HIUltrasonography");
            entity.Property(e => e.Hixray)
                .IsUnicode(false)
                .HasColumnName("HIXray");
            entity.Property(e => e.IdcardJobCard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IntervieweeAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IntervieweeComments).IsUnicode(false);
            entity.Property(e => e.IntervieweeContact)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IntervieweeDate).HasColumnType("datetime");
            entity.Property(e => e.IntervieweeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvOfficerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LeaveApprovalSheet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewsPaperReport)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianCertificate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostMortemReport)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalarySheet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ServiceBook)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GtliclaimSettlement>(entity =>
        {
            entity.HasKey(e => e.GtlisettlementId);

            entity.ToTable("GTLIClaimSettlement");

            entity.Property(e => e.GtlisettlementId).HasColumnName("GTLISettlementId");
            entity.Property(e => e.ClaimCommMemberName).IsUnicode(false);
            entity.Property(e => e.ClaimInvestigation).IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeathSummary).IsUnicode(false);
            entity.Property(e => e.DecisionofClaimCommittee).IsUnicode(false);
            entity.Property(e => e.GtliclaimId).HasColumnName("GTLIClaimId");
            entity.Property(e => e.Gtliid).HasColumnName("GTLIId");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gtlicontact>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.ToTable("GTLIContacts");

            entity.HasIndex(e => e.GtliId, "GtliId_GTLIContacts");

            entity.Property(e => e.ContactDesignation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactMobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GtliemployeeList>(entity =>
        {
            entity.HasKey(e => e.GtliEmployeeListsId);

            entity.ToTable("GTLIEmployeeList");

            entity.Property(e => e.ApplicantPhoto).IsUnicode(false);
            entity.Property(e => e.CareOfName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeCodeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeDesignation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeFullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JobLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NidNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName).IsUnicode(false);
            entity.Property(e => e.NomineePhoto).IsUnicode(false);
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GtlimakeaClaim>(entity =>
        {
            entity.HasKey(e => e.GtliclaimId);

            entity.ToTable("GTLIMakeaClaim");

            entity.HasIndex(e => e.Gtliid, "GtliId_GTLIMakeaClaim").HasFillFactor(90);

            entity.HasIndex(e => e.ClaimNotificationDate, "IX_GTLIMakeaClaim")
                .IsDescending()
                .HasFillFactor(90);

            entity.Property(e => e.GtliclaimId).HasColumnName("GTLIClaimId");
            entity.Property(e => e.AddressofNominee).IsUnicode(false);
            entity.Property(e => e.AttendanceSheet).IsUnicode(false);
            entity.Property(e => e.AwaitingComment).IsUnicode(false);
            entity.Property(e => e.AwaitingDeptId).HasColumnName("AwaitingDeptID");
            entity.Property(e => e.CertificateIssueNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimSlnoOftheCompany).HasColumnName("ClaimSLNoOftheCompany");
            entity.Property(e => e.CommentsView).IsUnicode(false);
            entity.Property(e => e.CompanyAddress).IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeathCertificate).IsUnicode(false);
            entity.Property(e => e.Discard).HasMaxLength(50);
            entity.Property(e => e.EmpIdJobId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmployerStatementofInjury).IsUnicode(false);
            entity.Property(e => e.EmploymentCertificate).IsUnicode(false);
            entity.Property(e => e.Firreport)
                .IsUnicode(false)
                .HasColumnName("FIRReport");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gtliid).HasColumnName("GTLIId");
            entity.Property(e => e.Hiancillarycharges)
                .IsUnicode(false)
                .HasColumnName("HIancillarycharges");
            entity.Property(e => e.HibillofConsultants)
                .IsUnicode(false)
                .HasColumnName("HIBillofConsultants");
            entity.Property(e => e.Hibillofmedicine)
                .IsUnicode(false)
                .HasColumnName("HIBillofmedicine");
            entity.Property(e => e.Hicbc)
                .IsUnicode(false)
                .HasColumnName("HICBC");
            entity.Property(e => e.Hidischargecertificate)
                .IsUnicode(false)
                .HasColumnName("HIDischargecertificate");
            entity.Property(e => e.HiemploymentCertificate)
                .IsUnicode(false)
                .HasColumnName("HIEmploymentCertificate");
            entity.Property(e => e.Hihospitalizationrecommendation)
                .IsUnicode(false)
                .HasColumnName("HIhospitalizationrecommendation");
            entity.Property(e => e.Hihospitalized)
                .IsUnicode(false)
                .HasColumnName("HIhospitalized");
            entity.Property(e => e.HiroomCharges)
                .IsUnicode(false)
                .HasColumnName("HIRoomCharges");
            entity.Property(e => e.HisurgicalOperationcharges)
                .IsUnicode(false)
                .HasColumnName("HISurgicalOperationcharges");
            entity.Property(e => e.Hiultrasonography)
                .IsUnicode(false)
                .HasColumnName("HIUltrasonography");
            entity.Property(e => e.Hixray)
                .IsUnicode(false)
                .HasColumnName("HIXray");
            entity.Property(e => e.IdcardJobcard).IsUnicode(false);
            entity.Property(e => e.IsPostAuditDone).HasColumnName("isPostAuditDone");
            entity.Property(e => e.IsPreAuditDone).HasColumnName("isPreAuditDone");
            entity.Property(e => e.IsSentToPreAudit).HasColumnName("isSentToPreAudit");
            entity.Property(e => e.LastResidenceAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LeaveApprovalSheet).IsUnicode(false);
            entity.Property(e => e.ListNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MajorDiseaseDisability)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NameofLifeInsured)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.NatureOfClaim)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NatureOfSubClaim).IsUnicode(false);
            entity.Property(e => e.NewsPaperReport).IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.PermanentandPartialDisability)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PermanentandTotalDisability)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhotographofConcerned).IsUnicode(false);
            entity.Property(e => e.PhysicianCertificate).IsUnicode(false);
            entity.Property(e => e.PlaceofIncident)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostMortemReport).IsUnicode(false);
            entity.Property(e => e.RecDateofOcf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RecDateofOCF");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RelationshipWithNominee)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalaryStatement).IsUnicode(false);
            entity.Property(e => e.ServicesBook).IsUnicode(false);
            entity.Property(e => e.Slno).HasColumnName("SLNo");
            entity.Property(e => e.Smsflag)
                .HasDefaultValue(0)
                .HasColumnName("SMSFlag");
            entity.Property(e => e.SumAssured).HasDefaultValue(0.0);
            entity.Property(e => e.SupplementaryAmount).HasDefaultValue(0.0);
            entity.Property(e => e.TimeofIncident)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnsettledComments).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gtlipayment>(entity =>
        {
            entity.HasKey(e => e.PrBmNo);

            entity.ToTable("GTLIPayments");

            entity.HasIndex(e => e.GtliId, "GtliId_GTLIPayments");

            entity.Property(e => e.BankName).IsUnicode(false);
            entity.Property(e => e.CheckNo).IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentPurpose)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SliclBankAcc).IsUnicode(false);
        });

        modelBuilder.Entity<Gtlipercent>(entity =>
        {
            entity.ToTable("Gtlipercent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MonthNo).HasColumnName("monthNo");
            entity.Property(e => e.Months).IsUnicode(false);
            entity.Property(e => e.NoOcf).HasColumnName("NoOCF");
            entity.Property(e => e.PremRec).HasColumnType("money");
            entity.Property(e => e.TotClaimPaid).HasColumnType("money");
        });

        modelBuilder.Entity<Gtlipremium>(entity =>
        {
            entity.ToTable("GTLIPremium");

            entity.HasIndex(e => e.GtliId, "GtliId_GTLIPremium");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.GtliSupplementaryId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gtlisetup>(entity =>
        {
            entity.HasKey(e => e.GtliId);

            entity.ToTable("GTLISetup");

            entity.HasIndex(e => e.CommencementDate, "CommenceDate_Gtlisetup_NonClustered_Idx");

            entity.HasIndex(e => e.IniEmpNo, "Member_GtliSetUp_NonClustered_Idx");

            entity.HasIndex(e => e.RegNo, "RegNo_GTLISetup_NonClustered_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.SerialNumber, "SerialNo_GtliSetup_NonClustered_Idx").HasFillFactor(90);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CsdelStatus).HasColumnName("CSDelStatus");
            entity.Property(e => e.CsdeliveredBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSDeliveredBy");
            entity.Property(e => e.CsdeliveryDate).HasColumnName("CSDeliveryDate");
            entity.Property(e => e.GroupCategory).HasDefaultValue(1);
            entity.Property(e => e.GroupType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GtliContract).IsUnicode(false);
            entity.Property(e => e.OrganisationAddress).IsUnicode(false);
            entity.Property(e => e.OrganisationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PremiumRateType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GtlistudentList>(entity =>
        {
            entity.ToTable("GTLIStudentList");

            entity.Property(e => e.BirthCertificateNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LegalGuardianDoc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LegalGuardianName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StudentFullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StudentPhoto).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gtlisupplementary>(entity =>
        {
            entity.ToTable("GTLISupplementary");

            entity.Property(e => e.GtliSupplementaryName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasKey(e => e.HolidayId).HasFillFactor(90);

            entity.Property(e => e.HolidayId).HasColumnName("HolidayID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.TotalDays).HasComputedColumnSql("(datediff(day,[FromDate],[ToDate])+(1))", false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IdraYearEnd>(entity =>
        {
            entity.ToTable("IdraYearEnd");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Df)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("df");
            entity.Property(e => e.Dt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dt");
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        modelBuilder.Entity<IdratotExp>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("IDRATotExp");

            entity.Property(e => e.OfficeRent34).HasColumnName("OfficeRent_34");
            entity.Property(e => e.OtherManagementExpenses35).HasColumnName("OtherManagementExpenses_35");
            entity.Property(e => e.SalaryOfEmployees33).HasColumnName("SalaryOfEmployees_33");
            entity.Property(e => e.TotalAdministrativeExpenses36).HasColumnName("TotalAdministrativeExpenses_36");
            entity.Property(e => e.TotalCommission15).HasColumnName("TotalCommission_15");
            entity.Property(e => e.TotalCommission32).HasColumnName("TotalCommission_32");
            entity.Property(e => e.TotalSalary20).HasColumnName("TotalSalary_20");
        });

        modelBuilder.Entity<Iislog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("IISLogs", "Audt");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Method)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Referer)
                .HasMaxLength(4096)
                .IsUnicode(false);
            entity.Property(e => e.ServerIpaddress)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("ServerIPAddress");
            entity.Property(e => e.ServerPort)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnName("TIME");
            entity.Property(e => e.UriQuery)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("URI_Query");
            entity.Property(e => e.UriStrem)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URI_Strem");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IncomingSm>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("InsertBankCustomSms"));

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Msg).IsUnicode(false);
            entity.Property(e => e.SenderNum)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Increment2024>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Increment2024");
        });

        modelBuilder.Entity<IndividualDeathClaim>(entity =>
        {
            entity.ToTable("IndividualDeathClaim");

            entity.Property(e => e.AbroadDeathCertificate).IsUnicode(false);
            entity.Property(e => e.AbroadOriginalPolicyDocument).IsUnicode(false);
            entity.Property(e => e.AccidentalDeathCertificate).IsUnicode(false);
            entity.Property(e => e.AccidentalOriginalPolicyDocument).IsUnicode(false);
            entity.Property(e => e.AgeProofOfNomineeOrClaimant).IsUnicode(false);
            entity.Property(e => e.AirwayBillOrDocument).IsUnicode(false);
            entity.Property(e => e.BankAcnoOfNominee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BankACnoOfNominee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankNameOfNominee).IsUnicode(false);
            entity.Property(e => e.BlankCheckOrBankStatementFileName).IsUnicode(false);
            entity.Property(e => e.CauseOfDeath).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeathCertificate).IsUnicode(false);
            entity.Property(e => e.EmploymentCertificate).IsUnicode(false);
            entity.Property(e => e.FirReport)
                .IsUnicode(false)
                .HasColumnName("FIR_Report");
            entity.Property(e => e.LastAddressOfDeceased).IsUnicode(false);
            entity.Property(e => e.LocalGovtDeathCertificate).IsUnicode(false);
            entity.Property(e => e.MinistryOfInterior).IsUnicode(false);
            entity.Property(e => e.NameOfClaimant)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameOfDeceased)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameOfNominee)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Noc)
                .IsUnicode(false)
                .HasColumnName("NOC");
            entity.Property(e => e.OriginalPolicyDocument).IsUnicode(false);
            entity.Property(e => e.Passport).IsUnicode(false);
            entity.Property(e => e.PlaceOfDeath).IsUnicode(false);
            entity.Property(e => e.PolicyNumber).IsUnicode(false);
            entity.Property(e => e.PostMortemReportOrWaiverCertificate).IsUnicode(false);
            entity.Property(e => e.PresentContractAddressOfNominee).IsUnicode(false);
            entity.Property(e => e.RelationshipOfClaimantWithNominee)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateOfAffair).IsUnicode(false);
            entity.Property(e => e.TimeOfDeath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfDeath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvBondBuy>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("InvBondBuy");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InterestFrequency).HasMaxLength(50);
            entity.Property(e => e.NameId).HasColumnName("NameID");
            entity.Property(e => e.Statas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvBuy>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("InvBuy");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.AcBrok)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Acname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACName");
            entity.Property(e => e.BankActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankActName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameId).HasColumnName("NameID");
            entity.Property(e => e.PayMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShareType)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .HasColumnName("typ");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Name).WithMany(p => p.InvBuys)
                .HasForeignKey(d => d.NameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvBuy_InvCreateInvestment");
        });

        modelBuilder.Entity<InvCreateInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("InvCreateInvestment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.InvCreateInvestments)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvCreateInvestment_InvTypeEntry");
        });

        modelBuilder.Entity<InvFdr>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("InvFDR");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fdramount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FDRAmount");
            entity.Property(e => e.Fdrno).HasColumnName("FDRNo");
            entity.Property(e => e.InterestAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InterestEarned).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InterestFrequency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InterestRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Source).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvFdrhistory>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("InvFDRHistory");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fdramount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FDRAmount");
            entity.Property(e => e.Fdrno).HasColumnName("FDRNo");
            entity.Property(e => e.InterestAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InterestEarned).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InterestFrequency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InterestRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Source).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvLand>(entity =>
        {
            entity.ToTable("InvLand");

            entity.Property(e => e.ActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(500);
            entity.Property(e => e.ProjectName).HasMaxLength(500);
        });

        modelBuilder.Entity<InvMasterNew>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_InvMaster_1New");

            entity.ToTable("InvMasterNew");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameId).HasColumnName("NameID");
            entity.Property(e => e.ProfitLoss).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvMasterNewBrok>(entity =>
        {
            entity.HasKey(e => e.Sl)
                .HasName("PK_InvMaster_1NewBrok")
                .HasFillFactor(90);

            entity.ToTable("InvMasterNewBrok");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.BrokId).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameId).HasColumnName("NameID");
            entity.Property(e => e.ProfitLoss).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ShareType)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvProp>(entity =>
        {
            entity.ToTable("InvProp");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amt).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Loc).IsUnicode(false);
            entity.Property(e => e.ProjectName).IsUnicode(false);
        });

        modelBuilder.Entity<InvSell>(entity =>
        {
            entity.HasKey(e => e.SellId);

            entity.ToTable("InvSell");

            entity.Property(e => e.SellId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AcBrok).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameId).HasColumnName("NameID");
            entity.Property(e => e.RemainingQty).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Name).WithMany(p => p.InvSells)
                .HasForeignKey(d => d.NameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvSell_InvCreateInvestment");
        });

        modelBuilder.Entity<InvShareSuspense>(entity =>
        {
            entity.ToTable("InvShareSuspense");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Amt).HasColumnType("numeric(18, 4)");
        });

        modelBuilder.Entity<InvTempMaster>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("InvTempMaster");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NameId).HasColumnName("NameID");
            entity.Property(e => e.UnrealizedGain).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvTypeEntry>(entity =>
        {
            entity.ToTable("InvTypeEntry");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Invfdrc>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Invfdrc");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FdrAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("fdrAmount");
            entity.Property(e => e.FdrNo).HasColumnName("fdrNo");
            entity.Property(e => e.InterestAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InterestEarned).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InterestFrequency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InterestRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Source).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvfdrcDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("InvfdrcDetail");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FdrNo).HasColumnName("fdrNo");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IpphoneContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("IPphoneContact");

            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ipextension).HasColumnName("IPextension");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IssueTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId);

            entity.ToTable("IssueTicket");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.Branch)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.ForwardDept)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ForwardTo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subject).IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IssueTicketErp>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasFillFactor(90);

            entity.ToTable("IssueTicketErp");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IssueDetails).IsUnicode(false);
            entity.Property(e => e.IssueImage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IssueStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IssueSubject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.SubmitTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<KycMaster>(entity =>
        {
            entity.HasKey(e => e.MasterKycId);

            entity.ToTable("KYC_Master");

            entity.HasIndex(e => e.ApplciantId, "ApplicantId_KYC_Master").HasFillFactor(90);

            entity.HasIndex(e => e.Fprid, "FprId_KYC_Master");

            entity.Property(e => e.MasterKycId).HasColumnName("MasterKYC_ID");
            entity.Property(e => e.ApplciantId).HasColumnName("ApplciantID");
            entity.Property(e => e.ApplicantFathersName).IsUnicode(false);
            entity.Property(e => e.ApplicantMothersName).IsUnicode(false);
            entity.Property(e => e.ApplicantName).IsUnicode(false);
            entity.Property(e => e.ApplicantSpouseName).IsUnicode(false);
            entity.Property(e => e.BankAccNo).IsUnicode(false);
            entity.Property(e => e.BankBranch).IsUnicode(false);
            entity.Property(e => e.BankName).IsUnicode(false);
            entity.Property(e => e.Comments)
                .IsUnicode(false)
                .HasColumnName("comments");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocExp).HasColumnName("docExp");
            entity.Property(e => e.DocId)
                .IsUnicode(false)
                .HasColumnName("DocID");
            entity.Property(e => e.DocType)
                .IsUnicode(false)
                .HasColumnName("docType");
            entity.Property(e => e.ETin)
                .IsUnicode(false)
                .HasColumnName("eTin");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fax).IsUnicode(false);
            entity.Property(e => e.IncomeSourceVerficationmethod).IsUnicode(false);
            entity.Property(e => e.InsTypeId).HasColumnName("insTypeID");
            entity.Property(e => e.JobDesc)
                .IsUnicode(false)
                .HasColumnName("jobDesc");
            entity.Property(e => e.JobTitle)
                .IsUnicode(false)
                .HasColumnName("jobTitle");
            entity.Property(e => e.MediumOfPayment)
                .IsUnicode(false)
                .HasColumnName("mediumOfPayment");
            entity.Property(e => e.MobileNo).IsUnicode(false);
            entity.Property(e => e.Nationality).IsUnicode(false);
            entity.Property(e => e.NoOfNominees).HasColumnName("noOfNominees");
            entity.Property(e => e.Occupation)
                .IsUnicode(false)
                .HasColumnName("occupation");
            entity.Property(e => e.OfficeNameAddress)
                .IsUnicode(false)
                .HasColumnName("officeNameAddress");
            entity.Property(e => e.PermanentAddress)
                .IsUnicode(false)
                .HasColumnName("permanentAddress");
            entity.Property(e => e.PresentAddress)
                .IsUnicode(false)
                .HasColumnName("presentAddress");
            entity.Property(e => e.ProductCatId).HasColumnName("ProductCatID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RiskCat)
                .IsUnicode(false)
                .HasColumnName("riskCat");
            entity.Property(e => e.SourceofIncome)
                .IsUnicode(false)
                .HasColumnName("sourceofIncome");
            entity.Property(e => e.TelOffice).IsUnicode(false);
            entity.Property(e => e.TelRes).IsUnicode(false);
            entity.Property(e => e.TotalPremiumAmount).HasColumnName("totalPremiumAmount");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.Updatedate).HasColumnType("datetime");
        });

        modelBuilder.Entity<KycNomineeDetail>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("KYC_NomineeDetails");

            entity.HasIndex(e => e.ApplicantId, "ApplicantId_KYC_NomineeDetails").HasFillFactor(90);

            entity.HasIndex(e => e.KycmasterId, "KYCMasterId_KYC_NomineeDetails");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            entity.Property(e => e.Createby)
                .IsUnicode(false)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.KycmasterId).HasColumnName("KYCMasterID");
            entity.Property(e => e.NomDocId)
                .IsUnicode(false)
                .HasColumnName("NomDocID");
            entity.Property(e => e.NomDocType).IsUnicode(false);
            entity.Property(e => e.NomFatherName).IsUnicode(false);
            entity.Property(e => e.NomFax).IsUnicode(false);
            entity.Property(e => e.NomMotherName).IsUnicode(false);
            entity.Property(e => e.NomOccupation).IsUnicode(false);
            entity.Property(e => e.NomSpouseName).IsUnicode(false);
            entity.Property(e => e.NomTelOffice).IsUnicode(false);
            entity.Property(e => e.Nomemail).IsUnicode(false);
            entity.Property(e => e.NomineeId).HasColumnName("NomineeID");
            entity.Property(e => e.NomineeName).IsUnicode(false);
            entity.Property(e => e.NomineePpname)
                .IsUnicode(false)
                .HasColumnName("NomineePPName");
            entity.Property(e => e.NomtelRes).IsUnicode(false);
            entity.Property(e => e.Relation).IsUnicode(false);
            entity.Property(e => e.Updateby)
                .IsUnicode(false)
                .HasColumnName("updateby");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
            entity.Property(e => e.UploadDocument).IsUnicode(false);
        });

        modelBuilder.Entity<LapseDocApproveUser>(entity =>
        {
            entity.ToTable("LapseDocApproveUser");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LapseHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("LapseHistory", tb => tb.HasTrigger("RevivedBonusCalculate"));

            entity.HasIndex(e => e.FprId, "NonClusteredIndex-20200516-105403").HasFillFactor(90);

            entity.HasIndex(e => new { e.Flag, e.ClaimFlag, e.LapseDate }, "indx_LapseHistory_Flag_ClaimFlag_LapseDate").HasFillFactor(90);

            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveManagement>(entity =>
        {
            entity.HasKey(e => e.LeaveId);

            entity.ToTable("LeaveManagement");

            entity.HasIndex(e => e.EmpId, "EmpId_LeaveManagement").HasFillFactor(90);

            entity.HasIndex(e => e.Flag, "indx_LeaveManagement_Flag");

            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CasualLeave).HasDefaultValue(14);
            entity.Property(e => e.CasualRemain).HasDefaultValue(14);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.EarnedLeave).HasDefaultValue(30);
            entity.Property(e => e.EarnedRemain).HasDefaultValue(30);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.LeaveTaken).HasDefaultValue(0);
            entity.Property(e => e.LeaveType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LeaveSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasFillFactor(90);

            entity.ToTable("LeaveSchedule");

            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Casual).HasDefaultValue(10);
            entity.Property(e => e.Earned).HasDefaultValue(30);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.JobStartDate).HasColumnName("Job_Start_Date");
            entity.Property(e => e.Maternity).HasDefaultValue(120);
            entity.Property(e => e.Paternity).HasDefaultValue(10);
        });

        modelBuilder.Entity<LiabilityNovDec2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Liability_NovDec_2022");

            entity.Property(e => e.Tid)
                .HasMaxLength(255)
                .HasColumnName("TID");
        });

        modelBuilder.Entity<LoadPrimaryId>(entity =>
        {
            entity.HasKey(e => e.PrimaryId)
                .HasName("PK_tmpAgentComCalcDetailsID")
                .HasFillFactor(90);

            entity.ToTable("LoadPrimaryID", "ssis");

            entity.Property(e => e.PrimaryId)
                .ValueGeneratedNever()
                .HasColumnName("PrimaryID");
        });

        modelBuilder.Entity<LoanBondFee>(entity =>
        {
            entity.ToTable("LoanBondFee");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Fee).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FrmAmt).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ToAmt).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<LoanCardAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_CardAssign");

            entity.Property(e => e.AcName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AcNumber)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApproveStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CardNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CardUniqueNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DispatchType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sliaccount)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SLIAccount");
            entity.Property(e => e.TokenId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalSvamount).HasColumnName("TotalSVAmount");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanChequeInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_ChequeInfo");

            entity.Property(e => e.AcName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AcNumber)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApproveStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoutingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SliaccountCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SLIAccountCode");
            entity.Property(e => e.SliaccountName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SLIAccountName");
        });

        modelBuilder.Entity<LoanComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Comments).IsUnicode(false);
        });

        modelBuilder.Entity<LoanDocument>(entity =>
        {
            entity.ToTable("Loan_Documents");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocTypeDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanEligibilityDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_EligibilityDetails");

            entity.Property(e => e.CommencementDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.NextLoanDueDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanEligibilityDetailsLog>(entity =>
        {
            entity.HasKey(e => e.LogIdid).HasFillFactor(90);

            entity.ToTable("Loan_EligibilityDetails_Log");

            entity.Property(e => e.LogIdid).HasColumnName("LogIDId");
            entity.Property(e => e.CommencementDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.NextLoanDueDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<LoanEligible>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_Eligible");

            entity.HasIndex(e => e.Status, "indx_Loan_Eligible_Status").HasFillFactor(90);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanEligibleLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_Eligible_Log");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoanEligibleId).HasColumnName("Loan_Eligible_Id");
            entity.Property(e => e.PolicyHolderMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanManualDisburseRecquest>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_ManualDisburseRecquest");

            entity.Property(e => e.ApproveStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_Master");

            entity.Property(e => e.Atmfees).HasColumnName("ATMFees");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasDefaultValue(0.0);
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastLoanPayDate).HasColumnType("datetime");
            entity.Property(e => e.NextLoanDueDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Smsfees).HasColumnName("SMSFees");
            entity.Property(e => e.SuspenseAmount).HasDefaultValue(0.0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanRepay>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_Repay");

            entity.HasIndex(e => new { e.LoanId, e.InstallmentNo }, "indx_Loan_Repay_LoanId_InstallmentNo").HasFillFactor(90);

            entity.Property(e => e.Atmfees).HasColumnName("ATMFees");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DepositDate).HasColumnType("datetime");
            entity.Property(e => e.LoanDueDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Smsfees).HasColumnName("SMSFees");
            entity.Property(e => e.SuspenseAmount).HasDefaultValue(0.0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoanRepayDelete>(entity =>
        {
            entity.ToTable("Loan_Repay_Delete");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Atmfees).HasColumnName("ATMFees");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DepositDate).HasColumnType("datetime");
            entity.Property(e => e.LoanDueDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Smsfees).HasColumnName("SMSFees");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoanTransactionDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Loan_TransactionDetails");

            entity.Property(e => e.BankTx)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CardUniqueNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DisburseStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoanDisburseDate).HasColumnType("datetime");
            entity.Property(e => e.Sliaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SLIAccount");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LogAgentJobDetail>(entity =>
        {
            entity.HasKey(e => e.LogAgentId);

            entity.ToTable("Log_Agent_Job_Details");

            entity.Property(e => e.LogBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogDate).HasColumnType("datetime");
            entity.Property(e => e.LogField).IsUnicode(false);
        });

        modelBuilder.Entity<LogPayEmpJobDetail>(entity =>
        {
            entity.HasKey(e => e.LogUserId);

            entity.ToTable("Log_PayEmp_Job_Details");

            entity.Property(e => e.LogBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogDate).HasColumnType("datetime");
            entity.Property(e => e.LogField).IsUnicode(false);
        });

        modelBuilder.Entity<LogTable>(entity =>
        {
            entity.ToTable("log_table");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Error)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ERROR");
        });

        modelBuilder.Entity<LoginUserList>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__LoginUse__1788CC4C989EC5CF");

            entity.ToTable("LoginUserList", "Admin");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<LpCardDeliveryDetail>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("LP_CardDeliveryDetails");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.ActivationCode).IsUnicode(false);
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.CardHolderName).IsUnicode(false);
            entity.Property(e => e.CardHolderStatus).IsUnicode(false);
            entity.Property(e => e.CardHolderType).IsUnicode(false);
            entity.Property(e => e.CardNo).IsUnicode(false);
            entity.Property(e => e.CardTypeId).HasColumnName("CardTypeID");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveredBy).IsUnicode(false);
            entity.Property(e => e.DeliveredByType).IsUnicode(false);
            entity.Property(e => e.MobileNo).IsUnicode(false);
            entity.Property(e => e.TrackNo).IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LpCardDetail>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_LP_CardDetails2020");

            entity.ToTable("LP_CardDetails");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CardHolderName).IsUnicode(false);
            entity.Property(e => e.CardHolderType).IsUnicode(false);
            entity.Property(e => e.CardNo).IsUnicode(false);
            entity.Property(e => e.CardTypeId).HasColumnName("CardTypeID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .IsUnicode(false)
                .HasColumnName("DocID");
            entity.Property(e => e.IssuedBy).IsUnicode(false);
            entity.Property(e => e.MemberSince).IsUnicode(false);
            entity.Property(e => e.PolicyIdz)
                .IsUnicode(false)
                .HasColumnName("PolicyIDz");
            entity.Property(e => e.ReissueId).HasColumnName("reissueID");
            entity.Property(e => e.SupCardId).HasColumnName("SupCardID");
        });

        modelBuilder.Entity<LpCardHolderPpdetail>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("LP_CardHolderPPDetails");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CardHolderPp)
                .IsUnicode(false)
                .HasColumnName("CardHolderPP");
            entity.Property(e => e.CardNo).IsUnicode(false);
            entity.Property(e => e.HolderType).IsUnicode(false);
        });

        modelBuilder.Entity<LpCardTypeDetail>(entity =>
        {
            entity.HasKey(e => e.CardTypeId);

            entity.ToTable("LP_CardTypeDetails");

            entity.Property(e => e.CardTypeId).HasColumnName("CardTypeID");
            entity.Property(e => e.CardTypeImg).IsUnicode(false);
            entity.Property(e => e.CardTypeName).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.MinSumAssured).HasDefaultValue(0.0);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LpMerchantCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("LP_MerchantCategory");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LpMerchantDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId);

            entity.ToTable("LP_MerchantDetail");

            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Detail).IsUnicode(false);
            entity.Property(e => e.MerchantId).HasColumnName("MerchantID");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LpMerchantName>(entity =>
        {
            entity.HasKey(e => e.MerchantId).HasFillFactor(90);

            entity.ToTable("LP_MerchantName");

            entity.Property(e => e.MerchantId).HasColumnName("MerchantID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.MerchantImage)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MerchantName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MailLog>(entity =>
        {
            entity.ToTable("MailLog");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Recipients)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<March23Applicant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("March23Applicant");

            entity.Property(e => e.Acc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AncestralDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentName).IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantId).ValueGeneratedOnAdd();
            entity.Property(e => e.ApplicantIdno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ApplicantIDNo");
            entity.Property(e => e.ApplicantMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantNameBang).HasMaxLength(500);
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPhotoName).IsUnicode(false);
            entity.Property(e => e.ApplicantPpname)
                .IsUnicode(false)
                .HasColumnName("ApplicantPPName");
            entity.Property(e => e.ApplicantSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlace).IsUnicode(false);
            entity.Property(e => e.ChestSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPoxVaccin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentHeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentWeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentlyWell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EduQualification).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EpilepticProblem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EyeDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FrequentCough)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GoitrousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificationMark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InfectiousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LongHolidayForIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiltDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PhysicalDisability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderSignature).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SmsFormate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StomachInfection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SummeryCommentBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SummeryCommentDate).HasColumnType("datetime");
            entity.Property(e => e.TypesOfOperation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnderWrittingComments).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UploadDocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UploadDocumentID");
            entity.Property(e => e.UrineStone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uwcomments)
                .IsUnicode(false)
                .HasColumnName("UWComments");
            entity.Property(e => e.Uwstatus).HasColumnName("UWStatus");
            entity.Property(e => e.WaistSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeightLossOrGain)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenBaby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEarnAbility)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEduQualification).IsUnicode(false);
            entity.Property(e => e.WomenHusbandMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandName)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKids)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKidsExpectation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenLastPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenPayTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenSourceOfIncome)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MarchComAdjustment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AchievedCom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdjustDate).HasColumnType("datetime");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MatCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("MatCheck");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Fprid).HasColumnName("fprid");
            entity.Property(e => e.Tpa).HasColumnName("tpa");
        });

        modelBuilder.Entity<MaturityBankDetail>(entity =>
        {
            entity.HasKey(e => e.BankDetailId);

            entity.Property(e => e.BankDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AcbranchName)
                .IsUnicode(false)
                .HasColumnName("ACBranchName");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AcholderName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACHolderName");
            entity.Property(e => e.Actype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACType");
            entity.Property(e => e.BankAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClaimId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FprId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameOfBank)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MaturityClaimProcess>(entity =>
        {
            entity.HasKey(e => e.ClaimId);

            entity.ToTable("MaturityClaimProcess", tb => tb.HasTrigger("TR_ClaimMaster_InsertUpdate_UMP_SB_Maturity_API_JSON"));

            entity.HasIndex(e => new { e.MaturityClaimType, e.FprId }, "indx_MaturityClaimProcess_MaturityClaimType_FprId").HasFillFactor(90);

            entity.Property(e => e.BonusAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaturityClaimAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.MaturityClaimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PremiumDeposited).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Profit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Sl)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.Tax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TaxableGross).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<MaturityClaimTemp>(entity =>
        {
            entity.HasKey(e => e.MaturityClaimId).HasFillFactor(90);

            entity.ToTable("MaturityClaimTemp");

            entity.Property(e => e.BonusAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MatType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaturityAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayableToCus).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.PremiumDeposited).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Profit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Tax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalMaturityAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MaturityListTable>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("MaturityListTable");

            entity.HasIndex(e => e.Fprid, "Fprid_MaturityListTable");

            entity.HasIndex(e => e.InsNo, "InsNo_MaturityListTable");

            entity.HasIndex(e => new { e.MaturityDate, e.IsPaid, e.Flag }, "IsPaid_Flag_MaturityDate_MaturityListTable_Idx");

            entity.HasIndex(e => e.ProductId, "PlanId_MaturityListTable");

            entity.HasIndex(e => new { e.PayStatus, e.IsPaid, e.Flag, e.MaturityDate }, "indx_MaturityListTable_PayStatus_IsPaid_Flag_MaturityDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.PayStatus, e.IsPaid, e.Flag, e.MaturityDate }, "indx_MaturityListTable_ProductID_PayStatus_IsPaid_Flag_MaturityDate").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AwaitingComment).IsUnicode(false);
            entity.Property(e => e.AwaitingDeptId).HasColumnName("AwaitingDeptID");
            entity.Property(e => e.Checked).HasDefaultValue(0);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.InsNo).HasDefaultValue(1);
            entity.Property(e => e.IsPostAuditDone)
                .HasDefaultValue(false)
                .HasColumnName("isPostAuditDone");
            entity.Property(e => e.IsPreAuditDone)
                .HasDefaultValue(false)
                .HasColumnName("isPreAuditDone");
            entity.Property(e => e.IsSentToPreAudit)
                .HasDefaultValue(false)
                .HasColumnName("isSentToPreAudit");
            entity.Property(e => e.Mmonths).IsUnicode(false);
            entity.Property(e => e.Myr).HasColumnName("MYr");
            entity.Property(e => e.PostAuditDoneBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PostAuditDoneDate).HasColumnType("datetime");
            entity.Property(e => e.PreAuditDoneBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PreAuditDoneDate).HasColumnType("datetime");
            entity.Property(e => e.PreAuditSentBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PreAuditSentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumDeposited).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Profit).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Tax).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TaxableAmt).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MaturityProcessDescription>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("MaturityProcessDescription");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.MaturityProcessDescription1)
                .IsUnicode(false)
                .HasColumnName("MaturityProcessDescription");
        });

        modelBuilder.Entity<MeetingSchedule>(entity =>
        {
            entity.HasKey(e => e.MeetingId);

            entity.ToTable("MeetingSchedule");

            entity.Property(e => e.MeetingId).HasColumnName("MeetingID");
            entity.Property(e => e.Agenda).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MeetingTime)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParticipantAgent).IsUnicode(false);
            entity.Property(e => e.ParticipantEmp).IsUnicode(false);
            entity.Property(e => e.Recur)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName).IsUnicode(false);
            entity.Property(e => e.Venue)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MetroSamdlist>(entity =>
        {
            entity.ToTable("MetroSAMDList");

            entity.Property(e => e.AgentName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MisscallLog>(entity =>
        {
            entity.ToTable("MisscallLog");

            entity.Property(e => e.CallTime).HasColumnType("datetime");
            entity.Property(e => e.CallUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReceiverType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MissingDeathClaim>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("MissingDeathClaim");

            entity.Property(e => e.Fprid).HasColumnName("FPRID");
        });

        modelBuilder.Entity<MissingSupplementaryClaim>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("MissingSupplementaryClaim");

            entity.Property(e => e.Fprid).HasColumnName("FPRID");
        });

        modelBuilder.Entity<MobileEmailChange>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_MobileEmailChange_1");

            entity.ToTable("MobileEmailChange");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.NewEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NewMobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrevEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrevMobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModeControl>(entity =>
        {
            entity.ToTable("ModeControl");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModeVal)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModeControl1>(entity =>
        {
            entity.ToTable("ModeControl1");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ModeVal)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModePerfSchedule>(entity =>
        {
            entity.ToTable("ModePerfSchedule");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Amt)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("amt");
            entity.Property(e => e.Perf1).HasColumnType("datetime");
            entity.Property(e => e.Perf2).HasColumnType("datetime");
            entity.Property(e => e.Perf3).HasColumnType("datetime");
            entity.Property(e => e.ProcName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RunAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<MonthWiseCommission>(entity =>
        {
            entity.ToTable("MonthWiseCommission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ait).HasColumnName("AIT");
            entity.Property(e => e.BillDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BillMonth).HasDefaultValueSql("(datepart(month,dateadd(month,(-1),getdate())))");
            entity.Property(e => e.BillNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BillYear).HasDefaultValueSql("(datepart(year,dateadd(month,(-1),getdate())))");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<MonthlyCommission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MonthlyC__3214EC0725AFD615");

            entity.ToTable("MonthlyCommission");

            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ait).HasColumnName("AIT");
            entity.Property(e => e.Approver)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Checker)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompositeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maker)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostToAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MonthlyPf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MonthlyPF");

            entity.Property(e => e.AgentType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orstatus");
        });

        modelBuilder.Entity<MotorExpense>(entity =>
        {
            entity.ToTable("MotorExpense");

            entity.Property(e => e.AgentId).HasMaxLength(50);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PayTo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MotorRegistration>(entity =>
        {
            entity.HasKey(e => e.MotorId);

            entity.ToTable("MotorRegistration");

            entity.Property(e => e.AssName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue(0);
        });

        modelBuilder.Entity<MrbaeditedRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MRBAEditedRecords");

            entity.Property(e => e.AccStatement).HasMaxLength(255);
            entity.Property(e => e.ActCode).HasMaxLength(255);
            entity.Property(e => e.ActName).HasMaxLength(255);
            entity.Property(e => e.Camount).HasColumnName("CAmount");
            entity.Property(e => e.CreateDate).HasMaxLength(255);
            entity.Property(e => e.Damount).HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasMaxLength(255);
            entity.Property(e => e.DelUser).HasMaxLength(255);
            entity.Property(e => e.Descrp).HasMaxLength(255);
            entity.Property(e => e.EntryDate).HasMaxLength(255);
            entity.Property(e => e.FromActCode).HasMaxLength(255);
            entity.Property(e => e.ToActCode).HasMaxLength(255);
            entity.Property(e => e.UserId).HasMaxLength(255);
            entity.Property(e => e.VoucherNo).HasMaxLength(255);
        });

        modelBuilder.Entity<NagadMerchantQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("NagadMerchantQueue");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NomineeAlteration>(entity =>
        {
            entity.ToTable("NomineeAlteration");

            entity.Property(e => e.AlterationReqDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.NomineeAge)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAllocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeGuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineePpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NomineePPName");
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UploadDocument)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NoticeBoardSetup>(entity =>
        {
            entity.HasKey(e => e.NoticeId).HasName("PK_BoticeBoardSetup");

            entity.ToTable("NoticeBoardSetup");

            entity.Property(e => e.NoticeId).HasColumnName("NoticeID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EventsTime)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NoticeTitle).IsUnicode(false);
            entity.Property(e => e.Venue)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NoticeParticipant>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_BoticeParticipants");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.EmpType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsInterested)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NoticeId).HasColumnName("NoticeID");
            entity.Property(e => e.ParticipantId).HasColumnName("ParticipantID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OnlinePaymentLog>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("OnlinePaymentLog");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode).IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlinePaymentLog2019>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("OnlinePaymentLog2019");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode).IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlinePaymentLog2020>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("OnlinePaymentLog2020");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode).IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlinePaymentLog2021>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("OnlinePaymentLog2021");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode).IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlinePaymentLog2022>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("OnlinePaymentLog2022");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode).IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlinePaymentLog2023>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("OnlinePaymentLog2023");

            entity.HasIndex(e => e.CreateDate, "indx_OnlinePaymentLog2023_CreateDate");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode).IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlinePaymentLog2024>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("OnlinePaymentLog2024");

            entity.HasIndex(e => e.CreateDate, "indx_CreateDate_2024").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlinePaymentLog2025>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("OnlinePaymentLog2025");

            entity.HasIndex(e => e.CreateDate, "indx_CreateDate_2025").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CardType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.RelationCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("val_id");
        });

        modelBuilder.Entity<OnlineUser>(entity =>
        {
            entity.ToTable("OnlineUser");

            entity.HasIndex(e => e.DocId, "IDX_AppNotification_Usr").HasFillFactor(90);

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecretAns)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrDue>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.HasIndex(e => e.Fprid, "FPRID-OrDues-Idx");

            entity.HasIndex(e => e.InsNo, "InsNo-OrDues-Idx");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Fprid)
                .HasDefaultValue(0)
                .HasColumnName("FPRID");
            entity.Property(e => e.OrEntryId).HasColumnName("OrEntryID");
            entity.Property(e => e.OrType).IsUnicode(false);
        });

        modelBuilder.Entity<OrFirstYrSummary>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Or_FirstYr_Summary");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FaId).HasColumnName("FaID");
            entity.Property(e => e.Months).IsUnicode(false);
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.Yr)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrRenewalSummary>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Or_Renewal_Summary");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FaId).HasColumnName("FaID");
            entity.Property(e => e.Months).IsUnicode(false);
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.Yr)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ormaster>(entity =>
        {
            entity.HasKey(e => e.OrmasterId).HasFillFactor(90);

            entity.ToTable("ORMaster", tb =>
                {
                    tb.HasTrigger("trg_Reinsurance_Pay_Chk");
                    tb.HasTrigger("trg_Reinsurance_Update_Chk");
                });

            entity.HasIndex(e => e.ApplicantId, "AppId_ORMaster");

            entity.HasIndex(e => e.BranchCode, "BranchCode_ORMaster_Idx");

            entity.HasIndex(e => e.Fprid, "Fprid_ORMaster");

            entity.HasIndex(e => e.Fprid, "INDX_ORMaster_FPRId>");

            entity.HasIndex(e => e.InstallmentTypeId, "InstallTypeId_ORMaster");

            entity.HasIndex(e => new { e.TotalInstallmentsPaid, e.TotalPremium, e.AgentId }, "NonClusteredIndex-20200106-171326").HasFillFactor(90);

            entity.HasIndex(e => e.NextPremiumDueDate, "Npdd_ORMaster").HasFillFactor(90);

            entity.HasIndex(e => e.NthYear, "NthYear_ORMaster").HasFillFactor(90);

            entity.HasIndex(e => e.OrentryId, "OrEntryID_ORMaster_Idx");

            entity.HasIndex(e => e.TotalNumberOfInstallments, "TotalNoIns_ORMaster");

            entity.HasIndex(e => new { e.ApplicantId, e.OrmasterId, e.Fprid, e.TotalPremium }, "_dta_index_ORMaster_5_1727397273__K3_K1_K2_K24_12_13_37").HasFillFactor(90);

            entity.HasIndex(e => e.AgentId, "indx_ORMaster_AgentId").HasFillFactor(90);

            entity.HasIndex(e => e.NextPremiumDueDate, "indx_ORMaster_NextPremiumDueDate").HasFillFactor(90);

            entity.HasIndex(e => e.ProductsId, "indx_ORMaster_ProductsId").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductsId, e.NthYear, e.NextPremiumDueDate }, "indx_ORMaster_ProductsId_NthYear_NextPremiumDueDate").HasFillFactor(90);

            entity.Property(e => e.OrmasterId).HasColumnName("ORMasterId");
            entity.Property(e => e.AgeVarify).IsUnicode(false);
            entity.Property(e => e.AlterSaflag).HasColumnName("AlterSAflag");
            entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocId).IsUnicode(false);
            entity.Property(e => e.EftnStatus).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Lien).HasDefaultValue(0);
            entity.Property(e => e.LienTerm).HasDefaultValue(0);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.OrentryId).HasColumnName("OREntryId");
            entity.Property(e => e.PolicyRiskAdditonalFactor).IsUnicode(false);
            entity.Property(e => e.RecFlag)
                .HasMaxLength(10)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SupplimentaryId).HasColumnName("SupplimentaryID");
            entity.Property(e => e.TransferBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrmultiEntry>(entity =>
        {
            entity.HasKey(e => e.OrentryId);

            entity.ToTable("ORMultiEntry", tb => tb.HasTrigger("UpdateEntryToORMaster"));

            entity.HasIndex(e => e.PaymentStatus, "IDX_ORMultiEntry_REntryDate");

            entity.HasIndex(e => e.Fprid, "IX_ORMultiEntry")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.OrentryDate, "OREDate_ORMultiEntry_1");

            entity.HasIndex(e => e.PaymentPurpose, "PayPurpose_ORMultiEntry_1");

            entity.HasIndex(e => e.PaymentStatus, "PayStatus_ORMultiEntry_1");

            entity.HasIndex(e => new { e.PaymentStatus, e.OrentryDate }, "indx_ORMultiEntry_PaymentStatus");

            entity.Property(e => e.OrentryId).HasColumnName("OREntryId");
            entity.Property(e => e.ActPrem).HasColumnType("money");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.OrentryDate).HasColumnName("OREntryDate");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentPurpose)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Outstanding2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Outstanding2021");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.OrentryDate).HasColumnName("OREntryDate");
        });

        modelBuilder.Entity<Outstanding2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Outstanding2022");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.OrentryDate).HasColumnName("OREntryDate");
        });

        modelBuilder.Entity<OutstandingLapse2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutstandingLapse2021");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.OrentryDate).HasColumnName("OREntryDate");
        });

        modelBuilder.Entity<OutstandingLapse2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OutstandingLapse2022");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.OrentryDate).HasColumnName("OREntryDate");
        });

        modelBuilder.Entity<OverCommissionPaid03222025>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasFillFactor(90);

            entity.ToTable("OverCommissionPaid_03_22_2025");

            entity.Property(e => e.AgentId).ValueGeneratedNever();
            entity.Property(e => e.AdjustedAmt).HasDefaultValue(0.0);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Bkp)
                .HasDefaultValue(1)
                .HasColumnName("BKP");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RemainingAmtApr).HasDefaultValue(0.0);
            entity.Property(e => e.ReportType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OverCommissionPaid03222025Updated>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OverCommissionPaid_03_22_2025_Updated");

            entity.Property(e => e.AdjustedStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Organization)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReportType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OverCommissionPaidReconcile04122025>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OverCommissionPaid_Reconcile_04_12_2025");

            entity.Property(e => e.AchievedCom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPayable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetReceiveable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OverPaid).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidCom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Payable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReconciliationExtra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Redeemed).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayCompProfileInfo>(entity =>
        {
            entity.HasKey(e => e.CompProId);

            entity.Property(e => e.CompAddress).IsUnicode(false);
            entity.Property(e => e.CompDescription).IsUnicode(false);
            entity.Property(e => e.CompEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompMobile1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompMobile2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompPfimage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CompPFImage");
            entity.Property(e => e.CompPflogo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CompPFLogo");
            entity.Property(e => e.CompPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompProName)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.CompWebsite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayDepartment>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.HasIndex(e => e.DeptName, "Unique_PayDepartments").IsUnique();

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayDesignation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasFillFactor(90);

            entity.HasIndex(e => e.DeptId, "IX_FK_PayDesignation_PayDepartment");

            entity.HasIndex(e => new { e.DeptId, e.DesignationName }, "Unique_PayDesignations")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignationShortFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayEmployeeJobDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasFillFactor(90);

            entity.HasIndex(e => e.DesignationId, "IX_FK_PayEmp_Job_Details_PayDesignation").HasFillFactor(90);

            entity.HasIndex(e => e.EmpId, "IX_FK_PayEmp_Job_Details_PayEmployeesBasicInfo").HasFillFactor(90);

            entity.HasIndex(e => e.RoleId, "IX_FK_PayEmp_Job_Details_PayRole").HasFillFactor(90);

            entity.HasIndex(e => new { e.EmpId, e.DesignationId, e.RoleId }, "Unique_PayEmployeeJobDetails")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.UserName, "Unique_PayEmployeeJobDetails_Username")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankStatus).HasDefaultValue(0);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpIdNo)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.EmpJobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Emp_Job_Status");
            entity.Property(e => e.EmpJobType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Emp_Job_Type");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grade).HasDefaultValue(0);
            entity.Property(e => e.IdCardStatus).HasDefaultValue(0);
            entity.Property(e => e.ImgStatus).HasDefaultValue(0);
            entity.Property(e => e.InchargeId).HasColumnName("InchargeID");
            entity.Property(e => e.JobEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_End_Date");
            entity.Property(e => e.JobStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_Start_Date");
            entity.Property(e => e.NidStatus).HasDefaultValue(0);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RoomNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Room_No");
            entity.Property(e => e.SignStatus).HasDefaultValue(0);
            entity.Property(e => e.Tinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TINNo");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Designation).WithMany(p => p.PayEmployeeJobDetails)
                .HasForeignKey(d => d.DesignationId)
                .HasConstraintName("FK_PayEmp_Job_Details_PayDesignation");

            entity.HasOne(d => d.Emp).WithMany(p => p.PayEmployeeJobDetails)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_PayEmp_Job_Details_PayEmployeesBasicInfo");
        });

        modelBuilder.Entity<PayEmployeeJobDetails20012024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayEmployeeJobDetails_20012024");

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpIdNo)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.EmpJobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Emp_Job_Status");
            entity.Property(e => e.EmpJobType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Emp_Job_Type");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InchargeId).HasColumnName("InchargeID");
            entity.Property(e => e.JobEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_End_Date");
            entity.Property(e => e.JobStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_Start_Date");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RoomNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Room_No");
            entity.Property(e => e.Tinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TINNo");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayEmployeesBasicInfo>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasFillFactor(90);

            entity.HasIndex(e => new { e.EmpName, e.Mobile1 }, "UniqueKey_PayEmployeesBasicInfoes")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Age)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Education).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FamilyContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.ImageName)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.Marital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Mobile2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nidimage)
                .HasMaxLength(100)
                .HasColumnName("NIDImage");
            entity.Property(e => e.OtizmStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtizmType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAdd)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RefContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Subject).HasMaxLength(250);
            entity.Property(e => e.SurName).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayEmployeesBasicInfoes1>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("PayEmployeesBasicInfoes1");

            entity.HasIndex(e => new { e.EmpName, e.Mobile1 }, "UniqueKey_PayEmployeesBasicInfoes1").IsUnique();

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Age)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FamilyContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.ImageName)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.Marital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Mobile2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtizmStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtizmType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAdd)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RefContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SurName).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayEmployeesBasicInfoes20012024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PayEmployeesBasicInfoes_20012024");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Age)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Education).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).ValueGeneratedOnAdd();
            entity.Property(e => e.EmpName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FamilyContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.ImageName)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.Marital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Mobile2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nidimage)
                .HasMaxLength(100)
                .HasColumnName("NIDImage");
            entity.Property(e => e.OtizmStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtizmType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAdd)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RefContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Subject).HasMaxLength(250);
            entity.Property(e => e.SurName).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayEmployeesBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasFillFactor(90);

            entity.ToTable("PayEmployeesBranch");

            entity.HasIndex(e => e.BranchStatus, "BrStatus_PayEmployeesBranch").HasFillFactor(90);

            entity.HasIndex(e => e.ProposedApproved, "PA_PayEmployeesBranch").HasFillFactor(90);

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.AdvanceAcc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BranchAddress).IsUnicode(false);
            entity.Property(e => e.BranchContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchIdno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BranchIDNo");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BranchStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Decoration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Division)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(0);
            entity.Property(e => e.Itcost).HasColumnName("ITCost");
            entity.Property(e => e.LandLordAccNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LandLordBankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LandLordContractDoc).IsUnicode(false);
            entity.Property(e => e.LandLordMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LandLordName).IsUnicode(false);
            entity.Property(e => e.LandLordNic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LandLordNIC");
            entity.Property(e => e.LandLordNicdoc)
                .IsUnicode(false)
                .HasColumnName("LandLordNICDoc");
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MapLocation)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ProposedApproved)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayPageObject>(entity =>
        {
            entity.HasKey(e => e.PageObjectId);

            entity.Property(e => e.PageMethodeName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PageName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PagePath)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.PageTypeName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayPageObjectRole>(entity =>
        {
            entity.HasKey(e => e.PageObjAccId)
                .HasName("PK_PayPageObjectRoles_1")
                .HasFillFactor(90);

            entity.HasIndex(e => e.PageObjectId, "IX_FK_PayPageObjectRoles_PayPageObjects").HasFillFactor(90);

            entity.HasIndex(e => e.RoleId, "IX_FK_PayPageObjectRoles_PayRole").HasFillFactor(90);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasFillFactor(90);

            entity.HasIndex(e => e.RoleName, "Unique_PayRoles").IsUnique();

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayScale>(entity =>
        {
            entity.ToTable("PayScale");

            entity.Property(e => e.PayScaleId).HasColumnName("PayScaleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesignationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Scale)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaymentApi2020>(entity =>
        {
            entity.ToTable("PaymentApi2020");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus)
                .HasDefaultValue(0)
                .HasColumnName("erp_status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentApi2021>(entity =>
        {
            entity.ToTable("PaymentApi2021");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus)
                .HasDefaultValue(0)
                .HasColumnName("erp_status");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentApi2022>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PaymentApi2022_New");

            entity.ToTable("PaymentApi2022", tb => tb.HasTrigger("FAidAdd2022New"));

            entity.HasIndex(e => e.ErpStatus, "IDX_ErpStatus_NonClustered_New");

            entity.HasIndex(e => e.FprId, "IDX_FPRID_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => e.CreateDate, "Idx_Date_NonClustered_New");

            entity.HasIndex(e => e.ForwardingNo, "Idx_Forwarding_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => e.TransectionId, "Idx_TransactionID_NonClustered_New").HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus)
                .HasDefaultValue(0)
                .HasColumnName("erp_status");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentApi2022Old>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PaymentApi2022");

            entity.ToTable("PaymentApi2022_Old", tb => tb.HasTrigger("FAidAdd2022"));

            entity.HasIndex(e => e.ErpStatus, "IDX_ErpStatus_NonClustered");

            entity.HasIndex(e => e.FprId, "IDX_FPRID_NonClustered");

            entity.HasIndex(e => e.CreateDate, "Idx_Date_NonClustered");

            entity.HasIndex(e => e.ForwardingNo, "Idx_Forwarding_NonClustered");

            entity.HasIndex(e => e.TransectionId, "Idx_TransactionID_NonClustered");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus)
                .HasDefaultValue(0)
                .HasColumnName("erp_status");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentApi2023>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("PaymentApi2023", tb => tb.HasTrigger("FAidAdd2023"));

            entity.HasIndex(e => new { e.ErpStatus, e.Status }, "IDX_ErpStatus_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => e.FprId, "IDX_FPRID_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => e.BankBranch, "Idx_BankBranch_NonClustered").HasFillFactor(90);

            entity.HasIndex(e => e.CreateDate, "Idx_Date_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => e.ForwardingNo, "Idx_Forwarding_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => e.TransectionId, "Idx_TransactionID_NonClustered_New").HasFillFactor(90);

            entity.HasIndex(e => e.CreateDate, "ind_PaymentApi2023_CreateDate");

            entity.HasIndex(e => e.CreateDate, "indx_PaymentApi2023_CreateDate");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus)
                .HasDefaultValue(0)
                .HasColumnName("erp_status");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentApi2024>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("PaymentApi2024", tb => tb.HasTrigger("FAidAdd2024"));

            entity.HasIndex(e => e.BankBranch, "indx_BankBranch_2024").HasFillFactor(90);

            entity.HasIndex(e => e.CreateDate, "indx_CreateDate_2024").HasFillFactor(90);

            entity.HasIndex(e => e.ForwardingNo, "indx_ForwardingNo_2024").HasFillFactor(90);

            entity.HasIndex(e => e.FprId, "indx_FprId_2024").HasFillFactor(90);

            entity.HasIndex(e => e.TransectionId, "indx_TransectionId_2024").HasFillFactor(90);

            entity.HasIndex(e => new { e.ErpStatus, e.Status }, "indx_erp_status_Status_2024").HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus)
                .HasDefaultValue(0)
                .HasColumnName("erp_status");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentApi2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("PaymentAPI2025");

            entity.HasIndex(e => e.TransectionId, "UQ_PaymentAPI2025_TransectionId").IsUnique();

            entity.HasIndex(e => e.BankBranch, "indx_BankBranch_2025").HasFillFactor(90);

            entity.HasIndex(e => e.CreateDate, "indx_CreateDate_2025").HasFillFactor(90);

            entity.HasIndex(e => e.ForwardingNo, "indx_ForwardingNo_2025").HasFillFactor(90);

            entity.HasIndex(e => e.FprId, "indx_FprId_2025").HasFillFactor(90);

            entity.HasIndex(e => e.TransectionId, "indx_TransectionId_2025").HasFillFactor(90);

            entity.HasIndex(e => new { e.ErpStatus, e.Status }, "indx_erp_status_Status_2025").HasFillFactor(90);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus)
                .HasDefaultValue(0)
                .HasColumnName("erp_status");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentApi2025Dup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentAPI2025_Dup");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErpStatus).HasColumnName("erp_status");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResponseNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
            entity.Property(e => e.Umname)
                .IsUnicode(false)
                .HasColumnName("UMName");
            entity.Property(e => e.UpdateBy)
                .IsUnicode(false)
                .HasColumnName("updateBy");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PaymentLog>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PaymentLog");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<PaymentLog2019>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PaymentLog2019");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<PaymentLog2020>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PaymentLog2020");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<PaymentLog2021>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PaymentLog2021");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<PaymentLog2022>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PaymentLog2022");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<PaymentLog2023>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("PaymentLog2023");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<PaymentLog2024>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("PaymentLog2024");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<PaymentLog2025>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("PaymentLog2025");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHoldersName).IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .IsUnicode(false)
                .HasColumnName("PolicyID");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
        });

        modelBuilder.Entity<Pdab>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PDAB");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Name).IsUnicode(false);
        });

        modelBuilder.Entity<PensionScheme>(entity =>
        {
            entity.HasKey(e => e.PensionId).HasFillFactor(90);

            entity.ToTable("PensionScheme");
        });

        modelBuilder.Entity<PensionSchemeDetailsAgent>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PensionSchemeDetails_Agents");

            entity.HasIndex(e => e.AgentId, "AgentId_PensionSchemeDetails_Agents").HasFillFactor(90);

            entity.HasIndex(e => e.Fprid, "FprId_PensionSchemeDetails_Agents").HasFillFactor(90);

            entity.HasIndex(e => e.Installmentno, "InsNo_PensionSchemeDetails_Agents");

            entity.HasIndex(e => e.MasterId, "Mid_PensionSchemeDetails_Agents").HasFillFactor(90);

            entity.HasIndex(e => e.OrentryId, "OEId_PensionSchemeDetails_Agents");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentType).IsUnicode(false);
            entity.Property(e => e.BasicComAmt).HasColumnName("basicComAmt");
            entity.Property(e => e.CreateBy)
                .IsUnicode(false)
                .HasColumnName("createBy");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.Fprid).HasColumnName("fprid");
            entity.Property(e => e.Installmentno).HasColumnName("installmentno");
            entity.Property(e => e.MasterId).HasColumnName("MasterID");
            entity.Property(e => e.Nthyear).HasColumnName("nthyear");
            entity.Property(e => e.OrentryId).HasColumnName("OREntryID");
            entity.Property(e => e.Pfamt).HasColumnName("PFAmt");
            entity.Property(e => e.Pfdate).HasColumnName("PFDate");
            entity.Property(e => e.SupComAmt).HasColumnName("supComAmt");
        });

        modelBuilder.Entity<PensionSchemeDetailsAgents07272022>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PensionSchemeDetails_Agents07272022");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentType).IsUnicode(false);
            entity.Property(e => e.BasicComAmt).HasColumnName("basicComAmt");
            entity.Property(e => e.CreateBy)
                .IsUnicode(false)
                .HasColumnName("createBy");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.Fprid).HasColumnName("fprid");
            entity.Property(e => e.Installmentno).HasColumnName("installmentno");
            entity.Property(e => e.MasterId).HasColumnName("MasterID");
            entity.Property(e => e.Nthyear).HasColumnName("nthyear");
            entity.Property(e => e.OrentryId).HasColumnName("OREntryID");
            entity.Property(e => e.Pfamt).HasColumnName("PFAmt");
            entity.Property(e => e.Pfdate).HasColumnName("PFDate");
            entity.Property(e => e.SupComAmt).HasColumnName("supComAmt");
        });

        modelBuilder.Entity<PensionSchemeDetailsAgentsBackUp>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PensionSchemeDetails_AgentsBackUp");

            entity.Property(e => e.Sl)
                .ValueGeneratedNever()
                .HasColumnName("SL");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentType).IsUnicode(false);
            entity.Property(e => e.BasicComAmt).HasColumnName("basicComAmt");
            entity.Property(e => e.CreateBy)
                .IsUnicode(false)
                .HasColumnName("createBy");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.Fprid).HasColumnName("fprid");
            entity.Property(e => e.Installmentno).HasColumnName("installmentno");
            entity.Property(e => e.MasterId).HasColumnName("MasterID");
            entity.Property(e => e.Nthyear).HasColumnName("nthyear");
            entity.Property(e => e.OrentryId).HasColumnName("OREntryID");
            entity.Property(e => e.Pfamt).HasColumnName("PFAmt");
            entity.Property(e => e.Pfdate).HasColumnName("PFDate");
            entity.Property(e => e.SupComAmt).HasColumnName("supComAmt");
        });

        modelBuilder.Entity<PensionSchemeMasterAgent>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("PensionScheme_Master_Agents");

            entity.HasIndex(e => e.AgentId, "AgentId_PensionScheme_Master_Agents").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.NoOfPf).HasColumnName("NoOfPF");
            entity.Property(e => e.TotalPfamt).HasColumnName("TotalPFAmt");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PensionSchemeMasterAgents07272022>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("PensionScheme_Master_Agents07272022");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.NoOfPf).HasColumnName("NoOfPF");
            entity.Property(e => e.TotalPfamt).HasColumnName("TotalPFAmt");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PfSerial6>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pfSerial__3214EC072DE5E3A5");

            entity.ToTable("pfSerial6");

            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<Pfcompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.ToTable("PFCompany");

            entity.Property(e => e.CompanyAddress).IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Policy10SvpaidUpRate>(entity =>
        {
            entity.ToTable("Policy10SVPaidUpRate");

            entity.Property(e => e.RateType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PolicyAdvisor>(entity =>
        {
            entity.ToTable("PolicyAdvisor");

            entity.Property(e => e.AdvisorTitleEng).IsUnicode(false);
            entity.Property(e => e.TitleType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PolicyApplicantNominee>(entity =>
        {
            entity.HasKey(e => e.NomineeId);

            entity.ToTable("PolicyApplicantNominee");

            entity.HasIndex(e => e.DocumentType, "DocumentType_PolicyApplicantNominee_Idx");

            entity.HasIndex(e => e.ApplicantId, "InsuranceDB_SQLOPS_PolicyApplicantNominee_1393529_1393528");

            entity.Property(e => e.DocumentId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.LegalGuardianNidno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LegalGuardianNIDNo");
            entity.Property(e => e.LegalGuardianNidphoto)
                .IsUnicode(false)
                .HasColumnName("LegalGuardianNIDPhoto");
            entity.Property(e => e.LegalGuardianPhoto).IsUnicode(false);
            entity.Property(e => e.LegalGuardianRelation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAge)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAllocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeDob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NomineeDOB");
            entity.Property(e => e.NomineeGuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineePpname)
                .IsUnicode(false)
                .HasColumnName("NomineePPName");
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UploadDocument).IsUnicode(false);
        });

        modelBuilder.Entity<PolicyApplicantsFamilyHistory>(entity =>
        {
            entity.HasKey(e => e.FamilyHistoryId);

            entity.ToTable("PolicyApplicantsFamilyHistory");

            entity.HasIndex(e => e.ApplicantId, "AppId_PolicyApplicantsFamilyHistory");

            entity.Property(e => e.Age)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgeDuringDeath)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CurrentPhysicalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeathReason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DurationOfLastIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsRemoved).HasColumnName("isRemoved");
            entity.Property(e => e.LifeStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Relation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YearOfDeath)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Applicant).WithMany(p => p.PolicyApplicantsFamilyHistories)
                .HasForeignKey(d => d.ApplicantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PolicyApplicantsFamilyHistory_PolicyApplicantsPersonalInfo");
        });

        modelBuilder.Entity<PolicyApplicantsPersonalInfo>(entity =>
        {
            entity.HasKey(e => e.ApplicantId);

            entity.ToTable("PolicyApplicantsPersonalInfo");

            entity.HasIndex(e => e.AgentId, "AgentId_PolicyApplicantsPersonalInfo").HasFillFactor(90);

            entity.HasIndex(e => e.ApplicantNameEng, "ApplicantNameEng_PolicyApplicantsPersonalInfo_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.Dob, "DOB_PolicyApplicantsPersonalInfo_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.NotificationStatusFlag, "NotiStatus_PolicyApplicantsPersonalInfo").HasFillFactor(90);

            entity.HasIndex(e => e.UploadDocumentId, "Uid_PolicyApplicantsPersonalInfo").HasFillFactor(90);

            entity.HasIndex(e => new { e.AgentId, e.NotificationStatusFlag }, "indx_PolicyApplicantsPersonalInfo_AgentId_NotificationStatusFlag").HasFillFactor(90);

            entity.HasIndex(e => e.MobileNo, "indx_PolicyApplicantsPersonalInfo_MobileNo").HasFillFactor(90);

            entity.HasIndex(e => e.NotificationStatusFlag, "indx_PolicyApplicantsPersonalInfo_NotificationStatusFlag");

            entity.Property(e => e.Acc)
                .HasMaxLength(10)
                .HasDefaultValue("n")
                .IsFixedLength();
            entity.Property(e => e.AncestralDisease)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.ApplicantDocumentName).IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantIdno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ApplicantIDNo");
            entity.Property(e => e.ApplicantMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantNameBang).HasMaxLength(500);
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPhotoName).IsUnicode(false);
            entity.Property(e => e.ApplicantPpname)
                .IsUnicode(false)
                .HasColumnName("ApplicantPPName");
            entity.Property(e => e.ApplicantSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlace).IsUnicode(false);
            entity.Property(e => e.ChestSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPox)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.ChikenPoxVaccin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasDefaultValue(0);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentHeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentWeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentlyWell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EduQualification).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EpilepticProblem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.EyeDisease)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.FrequentCough)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GoitrousDisease)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.IdentificationMark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InfectiousDisease)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.Lien).HasDefaultValue(0);
            entity.Property(e => e.LienTerm).HasDefaultValue(0);
            entity.Property(e => e.LongHolidayForIllness)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiltDisease)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PhysicalDisability)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.PolicyHolderSignature).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SmsFormate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StomachInfection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.SummeryCommentBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SummeryCommentDate).HasColumnType("datetime");
            entity.Property(e => e.TypesOfOperation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnderWrittingComments).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UploadDocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UploadDocumentID");
            entity.Property(e => e.UrineStone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.Uwcomments)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("UWComments");
            entity.Property(e => e.Uwstatus)
                .HasDefaultValue(0)
                .HasColumnName("UWStatus");
            entity.Property(e => e.WaistSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeightLossOrGain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No");
            entity.Property(e => e.WomenBaby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEarnAbility)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEduQualification).IsUnicode(false);
            entity.Property(e => e.WomenHusbandMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandName)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKids)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKidsExpectation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenLastPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenPayTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenSourceOfIncome)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Agent).WithMany(p => p.PolicyApplicantsPersonalInfos)
                .HasPrincipalKey(p => p.AgentId)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("FK_PolicyApplicantsPersonalInfo_AgentJobDetails");
        });

        modelBuilder.Entity<PolicyApplicantsPolicyInfo>(entity =>
        {
            entity.HasKey(e => e.ApplicantPolicyId);

            entity.ToTable("PolicyApplicantsPolicyInfo");

            entity.HasIndex(e => e.ApplicantId, "IX_PolicyApplicantsPolicyInfo").IsDescending();

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OtherDuePolicySli)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyAccpDate).HasColumnType("datetime");
            entity.Property(e => e.OtherPolicyAmount).HasDefaultValue(0.0);
            entity.Property(e => e.OtherPolicyCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyCondition)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyDuration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyRejectInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyPayee)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PolicyReason).IsUnicode(false);
            entity.Property(e => e.PolicyRiskAdditonalFactor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyRiskCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrBmNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceOfIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.YearlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ysapa).HasColumnName("YSAPA");

            entity.HasOne(d => d.Applicant).WithMany(p => p.PolicyApplicantsPolicyInfos)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_PolicyApplicantsPolicyInfo_PolicyApplicantsPersonalInfo");

            entity.HasOne(d => d.InstallmentType).WithMany(p => p.PolicyApplicantsPolicyInfos)
                .HasForeignKey(d => d.InstallmentTypeId)
                .HasConstraintName("FK_PolicyApplicantsPolicyInfo_PolicyInstallmentType");

            entity.HasOne(d => d.Policy).WithMany(p => p.PolicyApplicantsPolicyInfos)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("FK_PolicyApplicantsPolicyInfo_PolicyInfo");
        });

        modelBuilder.Entity<PolicyCategory>(entity =>
        {
            entity.HasKey(e => e.PolicyCategory1);

            entity.ToTable("PolicyCategory");

            entity.Property(e => e.PolicyCategory1)
                .ValueGeneratedNever()
                .HasColumnName("PolicyCategory");
            entity.Property(e => e.CategoryName).IsUnicode(false);
        });

        modelBuilder.Entity<PolicyDetail>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("InsertMetroAgentPF"));

            entity.HasIndex(e => e.Amdid, "AMDID_PolicyDetails_Idx");

            entity.HasIndex(e => e.Bcid, "BCID_PolicyDetails_Idx");

            entity.HasIndex(e => e.Bmid, "BMID_PolicyDetails_dx");

            entity.HasIndex(e => e.BranchId, "Branch_PolicyDetails");

            entity.HasIndex(e => e.Dcid, "DCID_PolicyDetails_Idx");

            entity.HasIndex(e => e.Dvcid, "DVCID_PolicyDetails_Idx");

            entity.HasIndex(e => e.Faid, "FaId_PolicyDetails").HasFillFactor(90);

            entity.HasIndex(e => e.Fprid, "Fprid_PolicyDetails").HasFillFactor(90);

            entity.HasIndex(e => e.InstallmentNo, "InstallmentNo_PolicyDetails_Idx");

            entity.HasIndex(e => e.NthYear, "NthYear_PolicyDetails");

            entity.HasIndex(e => e.Orstatus, "ORStatus_PolicyDetails_Idx");

            entity.HasIndex(e => e.Orentryid, "OrEId_PolicyDetails");

            entity.HasIndex(e => e.PayDate, "PayDate_PolicyDetails");

            entity.HasIndex(e => new { e.NthYear, e.Faid, e.PayDate }, "PolicyDetails_IDX_payDate").HasFillFactor(90);

            entity.HasIndex(e => e.Rcid, "RCID_PolicyDetails_Idx");

            entity.HasIndex(e => e.Samdid, "SamdId_PolicyDetails");

            entity.HasIndex(e => e.Sgmid, "SgmId_PolicyDetails_Idx");

            entity.HasIndex(e => e.SumAssured, "SumAssured_PolicyDetails_Idx");

            entity.HasIndex(e => e.TotalPremiumAmount, "TotalPremiumAmount_PolicyDetails__Idx");

            entity.HasIndex(e => e.Umid, "UMID__PolicyDetails_Idx");

            entity.HasIndex(e => new { e.BranchId, e.Samdid }, "indx_PolicyDetails_BranchID_SAMDID").HasFillFactor(90);

            entity.HasIndex(e => e.InstallmentNo, "indx_PolicyDetails_InstallmentNo");

            entity.HasIndex(e => new { e.Orstatus, e.PayDate }, "indx_PolicyDetails_ORStatus_PayDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.Orstatus, e.PayDate, e.InstallmentNo }, "indx_PolicyDetails_ORStatus_PayDate_InstallmentNo");

            entity.HasIndex(e => e.PayDate, "indx_PolicyDetails_PayDate");

            entity.HasIndex(e => new { e.PayDate, e.InstallmentNo, e.NthYear }, "indx_PolicyDetails_PayDate_InstallmentNo_NthYear");

            entity.HasIndex(e => new { e.PayDate, e.ReinsFlag }, "indx_PolicyDetails_Paydate_ReinsFlag").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.InstallmentNo }, "indx_PolicyDetails_ProductID_InstallmentNo");

            entity.HasIndex(e => e.Samdid, "indx_PolicyDetails_SAMDID").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amdid).HasColumnName("AMDID");
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid).HasColumnName("BMID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid).HasColumnName("FAID");
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.InstallmentTypeId).HasColumnName("InstallmentTypeID");
            entity.Property(e => e.Orentryid).HasColumnName("ORENTRYID");
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Rcid).HasColumnName("RCID");
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Sgmid).HasColumnName("SGMID");
            entity.Property(e => e.Umid).HasColumnName("UMID");
            entity.Property(e => e.UmpUrl).IsUnicode(false);
        });

        modelBuilder.Entity<PolicyDetailsFeb55656>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PolicyDetails_Feb_55656");

            entity.Property(e => e.Amdid).HasColumnName("AMDID");
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid).HasColumnName("BMID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid).HasColumnName("FAID");
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.InstallmentTypeId).HasColumnName("InstallmentTypeID");
            entity.Property(e => e.Orentryid).HasColumnName("ORENTRYID");
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Rcid).HasColumnName("RCID");
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Sgmid).HasColumnName("SGMID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Umid).HasColumnName("UMID");
            entity.Property(e => e.UmpUrl).IsUnicode(false);
        });

        modelBuilder.Entity<PolicyDetailsRestore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PolicyDetails_Restore_1");

            entity.ToTable("PolicyDetails_Restore");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amdid).HasColumnName("AMDID");
            entity.Property(e => e.Bcid).HasColumnName("BCID");
            entity.Property(e => e.Bmid).HasColumnName("BMID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Dcid).HasColumnName("DCID");
            entity.Property(e => e.Dvcid).HasColumnName("DVCID");
            entity.Property(e => e.Faid).HasColumnName("FAID");
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.InstallmentTypeId).HasColumnName("InstallmentTypeID");
            entity.Property(e => e.Orentryid).HasColumnName("ORENTRYID");
            entity.Property(e => e.Orstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORStatus");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Rcid).HasColumnName("RCID");
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Sgmid).HasColumnName("SGMID");
            entity.Property(e => e.Umid).HasColumnName("UMID");
            entity.Property(e => e.UmpUrl).IsUnicode(false);
        });

        modelBuilder.Entity<PolicyDoctorSecretInfo>(entity =>
        {
            entity.HasKey(e => e.DoctorsReportId);

            entity.ToTable("PolicyDoctorSecretInfo");

            entity.Property(e => e.AppAbnormality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppArtery)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppBloodPres)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppBreath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppChanceOfLiving)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppChestSizeAfterBr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppChestSizeDurBr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppEarlyAge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppHeartBeat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppHeartIssue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppHeartProb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppHeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppLeverProb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppLifeStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppMoreAge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppPulse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppSeek)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppSexDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppSkinDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppStomachProb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppTeethProb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppVisionProb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppWaistSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AppWeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DoctRegNo).IsUnicode(false);
            entity.Property(e => e.RelatedToApplicant)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UtAlbumen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UtExByDoct)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UtGravity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UtSugar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UtUrineNorm)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Applicant).WithMany(p => p.PolicyDoctorSecretInfos)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_PolicyDoctorSecretInfo_PolicyApplicantsPersonalInfo");

            entity.HasOne(d => d.Emp).WithMany(p => p.PolicyDoctorSecretInfos)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_PolicyDoctorSecretInfo_PayEmployeesBasicInfoes");
        });

        modelBuilder.Entity<PolicyEntryStatus>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PolicyEntryStatus");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Status).IsUnicode(false);
        });

        modelBuilder.Entity<PolicyFpr>(entity =>
        {
            entity.ToTable("PolicyFPR");

            entity.HasIndex(e => new { e.PolicyNo, e.Fprno, e.TotalPremium }, "Unique_PolicyFPR").IsUnique();

            entity.Property(e => e.PolicyFprid).HasColumnName("PolicyFPRId");
            entity.Property(e => e.Fprno).HasColumnName("FPRNo");
            entity.Property(e => e.PolicyNo)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.PolicyStartDate).HasColumnType("datetime");

            entity.HasOne(d => d.ApplicantPolicy).WithMany(p => p.PolicyFprs)
                .HasForeignKey(d => d.ApplicantPolicyId)
                .HasConstraintName("FK_PolicyFPR_PolicyApplicantsPolicyInfo");

            entity.HasOne(d => d.InsurncePlan).WithMany(p => p.PolicyFprs)
                .HasForeignKey(d => d.InsurncePlanId)
                .HasConstraintName("FK_PolicyFPR_PolicyInsurancePlan");

            entity.HasOne(d => d.Policy).WithMany(p => p.PolicyFprs)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("FK_PolicyFPR_PolicyInfo");

            entity.HasOne(d => d.Supplimentry).WithMany(p => p.PolicyFprs)
                .HasForeignKey(d => d.SupplimentryId)
                .HasConstraintName("FK_PolicyFPR_PolicySupplimentryEntry");
        });

        modelBuilder.Entity<PolicyHolderContest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PolicyHolderContest");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PolicyHolderContestTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PolicyHolderContestTemp");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PolicyHolderContestWinner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PolicyHolderContestWinner");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PolicyHolderTaxChallan>(entity =>
        {
            entity.ToTable("PolicyHolderTaxChallan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ChallanDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ChallanNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Month)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PolicyInfo>(entity =>
        {
            entity.HasKey(e => e.PolicyId);

            entity.ToTable("PolicyInfo");

            entity.HasIndex(e => new { e.PolicyId, e.PolicyName }, "Unique_PolicyInfo");

            entity.Property(e => e.AllowableExpPer).HasDefaultValue(0);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ImgName).HasMaxLength(100);
            entity.Property(e => e.PolicyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyInstallmentType>(entity =>
        {
            entity.HasKey(e => e.InstallmentTypeId);

            entity.ToTable("PolicyInstallmentType");

            entity.HasIndex(e => e.InstallmentTypeName, "Unique_PolicyInstallmentType");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.InstallmentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyInsurancePlan>(entity =>
        {
            entity.HasKey(e => e.InsurncePlanId).HasName("PK_InsurancePlan");

            entity.ToTable("PolicyInsurancePlan");

            entity.HasIndex(e => new { e.PolicyId, e.Age, e.Rate, e.TermOfYear }, "Unique_InsurancePlan").IsUnique();

            entity.Property(e => e.Age)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Policy).WithMany(p => p.PolicyInsurancePlans)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("FK_PolicyInsurancePlan_PolicyInfo");
        });

        modelBuilder.Entity<PolicyMedicalExamReport>(entity =>
        {
            entity.HasKey(e => e.MedicalRecordId).HasName("PK_MedicalExamReport");

            entity.ToTable("PolicyMedicalExamReport");

            entity.Property(e => e.BowelInfection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CancerDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExamDoctorsAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExamDoctorsName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ExamTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GenealogicalDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeartDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MuscleInjury)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NeuralHeadache)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReasonOfExam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SexDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpinalDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StayingMedical)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StayingPlace)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StayingReason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StayingTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VomitingDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenBirthDifficulties)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenBreastProblem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenLastPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenNoOfKid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenPregnancyStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.XrayExam)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Applicant).WithMany(p => p.PolicyMedicalExamReports)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_MedicalExamReport_PolicyApplicantsPersonalInfo");
        });

        modelBuilder.Entity<PolicyMr>(entity =>
        {
            entity.HasKey(e => e.MrId);

            entity.ToTable("PolicyMR", tb => tb.HasTrigger("AccEntry"));

            entity.Property(e => e.MrId).HasColumnName("MrID");
            entity.Property(e => e.AgentId).HasDefaultValue(0);
            entity.Property(e => e.BankName).IsUnicode(false);
            entity.Property(e => e.BranchId)
                .IsUnicode(false)
                .HasColumnName("BranchID");
            entity.Property(e => e.CheckNo).IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.PaidBy).IsUnicode(false);
            entity.Property(e => e.PaymentMethod).IsUnicode(false);
            entity.Property(e => e.PaymentPurpose).IsUnicode(false);
            entity.Property(e => e.SliclBankAcc).IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyPremiumReceipt>(entity =>
        {
            entity.HasKey(e => e.Fprid);

            entity.ToTable("PolicyPremiumReceipt", tb => tb.HasTrigger("InsertORMaster"));

            entity.HasIndex(e => e.ApplicantId, "AppId_PolicyPremiumReceipt_2");

            entity.HasIndex(e => e.CreateBy, "CreateBy_PolicyPremiumReceipt_Idx");

            entity.HasIndex(e => e.CreateDate, "CreateDate_PolicyPremiumReceipt_Idx");

            entity.HasIndex(e => e.PsdeliveryFlag, "DelivFlag_PolicyPremiumReceipt_2");

            entity.HasIndex(e => e.CommencementDate, "IX_PolicyPremiumReceipt").IsDescending();

            entity.HasIndex(e => e.Samdid, "IX_PolicyPremiumReceipt_1");

            entity.HasIndex(e => e.PsdeliveryFlag, "InsuranceDB_SQLOPS_PolicyPremiumReceipt_21652_21651");

            entity.HasIndex(e => e.PilicyId, "PolId_PolicyPremiumReceipt_2");

            entity.HasIndex(e => new { e.PilicyId, e.ApplicantId }, "_dta_index_PolicyPremiumReceipt_5_537337645__K11_K4_6_10");

            entity.HasIndex(e => new { e.InstallmentTypeName, e.PilicyId, e.Fprid, e.TotalPremium }, "_dta_index_PolicyPremiumReceipt_5_537337645__K13_K11_K1_K26_6_10");

            entity.HasIndex(e => e.CommencementDate, "indx_PolicyPremiumReceipt_CommencementDate");

            entity.HasIndex(e => new { e.Fprid, e.CommencementDate, e.PilicyId }, "indx_PolicyPremiumReceipt_CommencementDate_PilicyId_FPRId");

            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.Admitted)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AmdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMdId");
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AutoSmsFlag).HasDefaultValue(1);
            entity.Property(e => e.Bcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCId");
            entity.Property(e => e.Bmid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCId");
            entity.Property(e => e.DocId).IsUnicode(false);
            entity.Property(e => e.Dvcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCId");
            entity.Property(e => e.ExtraCondition).IsUnicode(false);
            entity.Property(e => e.Faid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Fprdate).HasColumnName("FPRDate");
            entity.Property(e => e.InstallmentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Language).HasDefaultValue(0);
            entity.Property(e => e.Lien).HasDefaultValue(0);
            entity.Property(e => e.LienYear).HasDefaultValue(0);
            entity.Property(e => e.NoPay).HasDefaultValue(1);
            entity.Property(e => e.NthYear).HasDefaultValue(1);
            entity.Property(e => e.PolicyNumber).IsUnicode(false);
            entity.Property(e => e.PrBmNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.PsdelDate)
                .HasColumnType("datetime")
                .HasColumnName("PSDelDate");
            entity.Property(e => e.PsdeliveredBy)
                .IsUnicode(false)
                .HasColumnName("PSDeliveredBy");
            entity.Property(e => e.PsdeliveredToAgentId).HasColumnName("PSDeliveredToAgentId");
            entity.Property(e => e.PsdeliveredToEmpId).HasColumnName("PSDeliveredToEmpId");
            entity.Property(e => e.PsdeliveryBranchId).HasColumnName("PSDeliveryBranchId");
            entity.Property(e => e.PsdeliveryFlag).HasColumnName("PSDeliveryFlag");
            entity.Property(e => e.Rcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RCId");
            entity.Property(e => e.Samdid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SGMId");
            entity.Property(e => e.SubPolicyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SurrOptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UmId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PolicyPremiumReceiptNew>(entity =>
        {
            entity.HasKey(e => e.Fprid);

            entity.ToTable("PolicyPremiumReceiptNew");

            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.Admitted)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AmdId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMdId");
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AutoSmsFlag).HasDefaultValue(1);
            entity.Property(e => e.Bcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCId");
            entity.Property(e => e.Bmid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BMId");
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DCId");
            entity.Property(e => e.DocId).IsUnicode(false);
            entity.Property(e => e.Dvcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCId");
            entity.Property(e => e.ExtraCondition).IsUnicode(false);
            entity.Property(e => e.Faid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAId");
            entity.Property(e => e.Fprdate).HasColumnName("FPRDate");
            entity.Property(e => e.InstallmentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Language).HasDefaultValue(0);
            entity.Property(e => e.Lien).HasDefaultValue(0);
            entity.Property(e => e.LienYear).HasDefaultValue(0);
            entity.Property(e => e.NoPay).HasDefaultValue(1);
            entity.Property(e => e.NthYear).HasDefaultValue(1);
            entity.Property(e => e.PolicyNumber).IsUnicode(false);
            entity.Property(e => e.PrBmNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.PsdelDate)
                .HasColumnType("datetime")
                .HasColumnName("PSDelDate");
            entity.Property(e => e.PsdeliveredBy)
                .IsUnicode(false)
                .HasColumnName("PSDeliveredBy");
            entity.Property(e => e.PsdeliveredToAgentId).HasColumnName("PSDeliveredToAgentId");
            entity.Property(e => e.PsdeliveredToEmpId).HasColumnName("PSDeliveredToEmpId");
            entity.Property(e => e.PsdeliveryBranchId).HasColumnName("PSDeliveryBranchId");
            entity.Property(e => e.PsdeliveryFlag).HasColumnName("PSDeliveryFlag");
            entity.Property(e => e.Rcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RCId");
            entity.Property(e => e.Samdid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SGMId");
            entity.Property(e => e.SubPolicyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SurrOptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UmId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitOfficeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PolicyProvisionalReceipt>(entity =>
        {
            entity.HasKey(e => e.PrBmNo);

            entity.ToTable("PolicyProvisionalReceipt", tb =>
                {
                    tb.HasTrigger("TRG_AgentComPR");
                    tb.HasTrigger("TRG_UpdateAgentComPR");
                });

            entity.HasIndex(e => e.ApplicantId, "AppId_PolicyProvisionalReceipt").HasFillFactor(90);

            entity.HasIndex(e => e.BranchCode, "BrId_PolicyProvisionalReceipt").HasFillFactor(90);

            entity.HasIndex(e => e.PrBmDate, "PrDate_PolicyProvisionalReceipt");

            entity.Property(e => e.BranchCode).HasDefaultValue(2);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Flag).HasMaxLength(50);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentPurpose)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrBmNoChar)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Agent).WithMany(p => p.PolicyProvisionalReceipts)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("FK_PolicyProvisionalReceipt_AgentBasicInfo");

            entity.HasOne(d => d.Applicant).WithMany(p => p.PolicyProvisionalReceipts)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_PolicyProvisionalReceipt_PolicyApplicantsPersonalInfo");
        });

        modelBuilder.Entity<PolicyStampCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("PolicyStampCategory");

            entity.Property(e => e.CategoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<PolicyStampIn>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("PolicyStampIn");

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyStampInventory>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PolicyStampInventory");

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyStampRequisition>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("PolicyStampRequisition");

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ReferTo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyStampUsage>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
        });

        modelBuilder.Entity<PolicyStatusCheck>(entity =>
        {
            entity.ToTable("PolicyStatusCheck");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PolicySupplementry>(entity =>
        {
            entity.HasKey(e => e.SupplimentryPolicyId);

            entity.ToTable("PolicySupplementry");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicySupplimentryEntry>(entity =>
        {
            entity.HasKey(e => e.SupplimentryId).HasName("PK_SubProduct");

            entity.ToTable("PolicySupplimentryEntry");

            entity.HasIndex(e => e.SupplimentryId, "Unique_PolicySupplimentryEntry").IsUnique();

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.SubPolicyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SubPolicyValue).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicySurrenderValue>(entity =>
        {
            entity.HasKey(e => e.SurrenderId);

            entity.ToTable("PolicySurrenderValue");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.InstRunByComp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SurOpt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SurrOptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyToDeed>(entity =>
        {
            entity.ToTable("PolicyToDeed");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprdate).HasColumnName("FPRDate");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.StampDeliveryDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PolicyToDeedStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UderwrittingToDeedStatus");

            entity.ToTable("PolicyToDeedStatus");

            entity.Property(e => e.Description).IsUnicode(false);
        });

        modelBuilder.Entity<PopUpDoc>(entity =>
        {
            entity.ToTable("PopUpDoc");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.ImgName).HasMaxLength(100);
            entity.Property(e => e.IsShow).HasColumnName("isShow");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<PorichoyDatum>(entity =>
        {
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnName("dateOfBirth");
            entity.Property(e => e.FathersNameBn)
                .HasMaxLength(150)
                .HasColumnName("fathersNameBN");
            entity.Property(e => e.FathersNameEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fathersNameEN");
            entity.Property(e => e.FullNameBn)
                .HasMaxLength(150)
                .HasColumnName("fullNameBN");
            entity.Property(e => e.FullNameEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("fullNameEN");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.MothersNameBn)
                .HasMaxLength(150)
                .HasColumnName("mothersNameBN");
            entity.Property(e => e.MothersNameEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mothersNameEN");
            entity.Property(e => e.NationalIdNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nationalIdNumber");
            entity.Property(e => e.OldNationalIdNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("oldNationalIdNumber");
            entity.Property(e => e.PermanentAddressBn).HasColumnName("permanentAddressBN");
            entity.Property(e => e.PermenantAddressEn)
                .IsUnicode(false)
                .HasColumnName("permenantAddressEN");
            entity.Property(e => e.PhotoUrl)
                .IsUnicode(false)
                .HasColumnName("photoUrl");
            entity.Property(e => e.PresentAddressBn).HasColumnName("presentAddressBN");
            entity.Property(e => e.PresentAddressEn)
                .IsUnicode(false)
                .HasColumnName("presentAddressEN");
            entity.Property(e => e.Profession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profession");
            entity.Property(e => e.SpouseNameBn)
                .HasMaxLength(150)
                .HasColumnName("spouseNameBN");
            entity.Property(e => e.SpouseNameEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("spouseNameEN");
        });

        modelBuilder.Entity<PrDetail>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.HasIndex(e => e.Amdid, "AmdId_PrDetails_Idx");

            entity.HasIndex(e => e.ApplicantId, "AppId_PrDetails").HasFillFactor(90);

            entity.HasIndex(e => e.Bcid, "BcId_PrDetails_Idx");

            entity.HasIndex(e => e.Bmid, "BmId_PrDetails_Idx");

            entity.HasIndex(e => e.BranchId, "BrId_PrDetails").HasFillFactor(90);

            entity.HasIndex(e => e.Dvcid, "DVCID_PrDetails_Idx");

            entity.HasIndex(e => e.Dcid, "DcID_PrDetails_Idx");

            entity.HasIndex(e => e.FaId, "FaId_PrDetails").HasFillFactor(90);

            entity.HasIndex(e => e.PrBmDate, "PrDate_PrDetails");

            entity.HasIndex(e => e.Rcid, "RCID_PrDetails_Idx");

            entity.HasIndex(e => e.SamdId, "SamdId_PrDetails");

            entity.HasIndex(e => e.Sgmid, "SgmId_PrDetails_Idx");

            entity.HasIndex(e => e.TotalPremiumAmount, "TotalPremium_PrDetails_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.Umid, "UMId_PrDetails_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.PrBmDate, "indx_PrDetails_PrBmDate");

            entity.HasIndex(e => new { e.SamdId, e.BranchId }, "indx_PrDetails_SamdID_BranchID");

            entity.HasIndex(e => e.PrBmNo, "prbmNo_PrDetails_Idx");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amdid).HasColumnName("amdid");
            entity.Property(e => e.Bcid).HasColumnName("bcid");
            entity.Property(e => e.Bmid).HasColumnName("bmid");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Dcid).HasColumnName("dcid");
            entity.Property(e => e.Dvcid).HasColumnName("dvcid");
            entity.Property(e => e.FaId).HasColumnName("FaID");
            entity.Property(e => e.InsTypeId).HasColumnName("InsTypeID");
            entity.Property(e => e.Rcid).HasColumnName("rcid");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.Sgmid).HasColumnName("sgmid");
            entity.Property(e => e.Umid).HasColumnName("umid");
        });

        modelBuilder.Entity<PrDetailsFeb55656>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PrDetails_Feb_55656");

            entity.Property(e => e.Amdid).HasColumnName("amdid");
            entity.Property(e => e.Bcid).HasColumnName("bcid");
            entity.Property(e => e.Bmid).HasColumnName("bmid");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Dcid).HasColumnName("dcid");
            entity.Property(e => e.Dvcid).HasColumnName("dvcid");
            entity.Property(e => e.FaId).HasColumnName("FaID");
            entity.Property(e => e.InsTypeId).HasColumnName("InsTypeID");
            entity.Property(e => e.Rcid).HasColumnName("rcid");
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.Sgmid).HasColumnName("sgmid");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Umid).HasColumnName("umid");
        });

        modelBuilder.Entity<PrSummary>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PrSummary");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FaId).HasColumnName("FaID");
            entity.Property(e => e.Months).IsUnicode(false);
            entity.Property(e => e.SamdId).HasColumnName("SamdID");
            entity.Property(e => e.Yr)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PremiumIncomeRpt>(entity =>
        {
            entity.ToTable("PremiumIncomeRpt");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Df)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("df");
            entity.Property(e => e.Dt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dt");
            entity.Property(e => e.Typ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        modelBuilder.Entity<PrivilegeCardAgent>(entity =>
        {
            entity.ToTable("PrivilegeCardAgent");

            entity.Property(e => e.AccNo).HasMaxLength(100);
            entity.Property(e => e.BankBranch).HasMaxLength(200);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.CardType).HasMaxLength(100);
            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PrivilegeCardPolicyHolder>(entity =>
        {
            entity.ToTable("PrivilegeCardPolicyHolder");

            entity.Property(e => e.AccNo).HasMaxLength(100);
            entity.Property(e => e.BankBranch).HasMaxLength(200);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.CardType).HasMaxLength(100);
            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProcedureLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("ProcedureLog");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.AdditionalInfo).HasMaxLength(1000);
            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.DatabaseName).HasMaxLength(100);
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ProcedureName).HasMaxLength(400);
        });

        modelBuilder.Entity<ProcessWithCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProcessW");

            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CrCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DrCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Statas)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProcessWithCodesMonthWise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProcessWMW");

            entity.ToTable("ProcessWithCodesMonthWise");

            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bsa).HasColumnName("BSA");
            entity.Property(e => e.CrCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DrCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pfamt).HasColumnName("PFAmt");
            entity.Property(e => e.ProcessCodesId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Statas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateByDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProcurementCategory>(entity =>
        {
            entity.ToTable("ProcurementCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ProcurementCommittee>(entity =>
        {
            entity.ToTable("ProcurementCommittee");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ProcurementDetail>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("ProcurementDetail");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DeadLine).HasColumnType("smalldatetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.ItemDescription).HasMaxLength(1000);
            entity.Property(e => e.ItemName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcCategoryId).HasColumnName("ProcCategoryID");
            entity.Property(e => e.ProcMasterId).HasColumnName("ProcMasterID");
            entity.Property(e => e.ProcQuotId).HasColumnName("ProcQuotID");
            entity.Property(e => e.Remark).HasMaxLength(2000);
            entity.Property(e => e.RequisitionNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("created");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ProcurementMaster>(entity =>
        {
            entity.ToTable("ProcurementMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProcurementQuotation>(entity =>
        {
            entity.ToTable("ProcurementQuotation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProcDetailId).HasColumnName("ProcDetailID");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");
        });

        modelBuilder.Entity<ProfitInforce>(entity =>
        {
            entity.HasKey(e => e.Age);

            entity.ToTable("ProfitInforce");

            entity.Property(e => e.Age)
                .ValueGeneratedNever()
                .HasColumnName("age");
            entity.Property(e => e.Death).HasColumnName("death");
            entity.Property(e => e.Lx).HasColumnName("lx");
            entity.Property(e => e.Qx).HasColumnName("qx");
        });

        modelBuilder.Entity<Psdelivery>(entity =>
        {
            entity.HasKey(e => e.PsdelId);

            entity.ToTable("PSDelivery");

            entity.Property(e => e.PsdelId).HasColumnName("PSDelId");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Psamount).HasColumnName("PSAmount");
        });

        modelBuilder.Entity<PurchasePriceQuotation>(entity =>
        {
            entity.ToTable("PurchasePriceQuotation");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VendorPriceDoc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PurchaseProductReceive>(entity =>
        {
            entity.ToTable("PurchaseProductReceive");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PurchaseReqisition>(entity =>
        {
            entity.ToTable("PurchaseReqisition");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalReceivedQuantity).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PushPullLog>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("PushPullLog", tb => tb.HasTrigger("InsertCheck"));

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.MobileNumber).IsUnicode(false);
            entity.Property(e => e.Msg).IsUnicode(false);
            entity.Property(e => e.ReadBy).IsUnicode(false);
            entity.Property(e => e.ReadDate).HasColumnType("datetime");
            entity.Property(e => e.Type).IsUnicode(false);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<QuAlterIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuAlterI__3213E83F35B1E07B");

            entity.ToTable("QuAlterIssue");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fprid).HasColumnName("fprid");
        });

        modelBuilder.Entity<QuConfigTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QuConfigTab");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.JobName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Job_Name");
            entity.Property(e => e.JobStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Job_status");
            entity.Property(e => e.SelectTop).HasColumnName("Select_Top");
            entity.Property(e => e.WaitDelay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Wait_Delay");
        });

        modelBuilder.Entity<QuSetup>(entity =>
        {
            entity.HasKey(e => e.QuId);

            entity.ToTable("QuSetup");

            entity.HasIndex(e => new { e.FprId, e.AgentProcessBusComPf, e.QuId }, "indx_QuSetup_FprID_AgentProcessBusComPf_QuID").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrEntryId, e.OrProcess }, "indx_QuSetup_OrEntryID_OrProcess");

            entity.HasIndex(e => new { e.OrProcess, e.MatProcess, e.AgentProcessBusComPf, e.LapsProcess, e.PolicyProcess }, "indx_QuSetup_OrProcess_MatProcess_AgentProcessBusComPf_LapsProcess_PolicyProcess");

            entity.HasIndex(e => new { e.OrProcess, e.SmsProcess }, "indx_QuSetup_OrProcess_SmsProcess");

            entity.HasIndex(e => new { e.OrProcess, e.TrnId }, "indx_QuSetup_OrProcess_TrnID").HasFillFactor(90);

            entity.Property(e => e.QuId).HasColumnName("QuID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FprId).HasColumnName("FprID");
            entity.Property(e => e.OrEntryId).HasColumnName("OrEntryID");
            entity.Property(e => e.OrProcess).HasDefaultValue(1);
            entity.Property(e => e.PTotalPolicyAmount).HasColumnName("P_TotalPolicyAmount");
            entity.Property(e => e.PYsapa).HasColumnName("P_ysapa");
            entity.Property(e => e.TrnId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TrnID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<QuSetupBkp>(entity =>
        {
            entity.HasKey(e => e.QuBkpid);

            entity.ToTable("QuSetup_BKP");

            entity.Property(e => e.QuBkpid).HasColumnName("QuBKPID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FprId).HasColumnName("FprID");
            entity.Property(e => e.OrEntryId).HasColumnName("OrEntryID");
            entity.Property(e => e.PTotalPolicyAmount).HasColumnName("P_TotalPolicyAmount");
            entity.Property(e => e.PYsapa).HasColumnName("P_ysapa");
            entity.Property(e => e.PostedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.QuId).HasColumnName("QuID");
            entity.Property(e => e.TrnId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TrnID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<QueryCategory>(entity =>
        {
            entity.ToTable("QueryCategory");

            entity.Property(e => e.CategoryName).HasMaxLength(200);
            entity.Property(e => e.CreateBy).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(100);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RankingFrenquency>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("RankingFrenquency");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mf)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RptName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SamdId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Yf)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Yt)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RankingPrOr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RANKING_PR_OR");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Agent).IsUnicode(false);
            entity.Property(e => e.AgentType).IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Branch).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Samd).IsUnicode(false);
        });

        modelBuilder.Entity<RawtblAgent>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("RAWtblAgent");

            entity.HasIndex(e => new { e.AgentId, e.RptType }, "indx_RAWtblAgent_RptType_AgentId").HasFillFactor(90);

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sl");
            entity.Property(e => e.DayOfYearVal).HasColumnType("datetime");
            entity.Property(e => e.PayType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RptType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RawtblAgentTeam>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("RAWtblAgentTeam");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("sl");
            entity.Property(e => e.AgentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agentType");
            entity.Property(e => e.DayOfYearVal).HasColumnType("datetime");
            entity.Property(e => e.PayType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RptType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReInsuranceCalculation>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ReInsuranceCalculation");

            entity.Property(e => e.ApplicantNameEng).IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeId).HasDefaultValue(0);
            entity.Property(e => e.Occupation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PolicyRiskCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReInsuranceCalculation1>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ReInsuranceCalculation1");

            entity.Property(e => e.ApplicantNameEng).IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeId).HasDefaultValue(0);
            entity.Property(e => e.Occupation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PayStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyRiskCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReInsuranceCalculationTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ReInsuranceCalculationTest");

            entity.Property(e => e.ApplicantNameEng).IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeId).HasDefaultValue(0);
            entity.Property(e => e.Occupation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PayStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyRiskCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReInsuranceDeletedLog>(entity =>
        {
            entity.HasKey(e => e.DeletedId);

            entity.ToTable("ReInsuranceDeletedLog");

            entity.Property(e => e.DeletedId).HasColumnName("DeletedID");
            entity.Property(e => e.PosytedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.SummaryId).HasColumnName("SummaryID");
        });

        modelBuilder.Entity<ReadRfid>(entity =>
        {
            entity.HasKey(e => e.Rfid);

            entity.ToTable("ReadRfid");

            entity.Property(e => e.Rfid)
                .ValueGeneratedNever()
                .HasColumnName("RFID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecAssetStock>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("RecAssetStock");

            entity.Property(e => e.AssetDeseription).IsUnicode(false);
            entity.Property(e => e.Branch).IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RecExpense>(entity =>
        {
            entity.HasKey(e => e.RecExpId);

            entity.ToTable("RecExpense");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpPaid).HasMaxLength(50);
            entity.Property(e => e.ExpType)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RecievableList>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_RecievableList2020");

            entity.ToTable("RecievableList");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Purpose).IsUnicode(false);
        });

        modelBuilder.Entity<RecurringJournal>(entity =>
        {
            entity.ToTable("RecurringJournal");

            entity.HasIndex(e => new { e.RecuId, e.Cr }, "indx_RecurringJournal_RecuId_Cr");

            entity.HasIndex(e => new { e.RecuId, e.Dr }, "indx_RecurringJournal_RecuId_Dr");

            entity.Property(e => e.Cr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Dr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Memo)
                .HasMaxLength(5000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RecurringJournalC>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("RecurringJournalC");

            entity.Property(e => e.Cr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Dr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Memo)
                .HasMaxLength(5000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RecurringSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("RecurringSchedule");

            entity.Property(e => e.EntryBy).HasMaxLength(50);
            entity.Property(e => e.Frequency).HasMaxLength(50);
            entity.Property(e => e.Memo).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<RecurringScheduleC>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("RecurringScheduleC");

            entity.Property(e => e.EntryBy).HasMaxLength(50);
            entity.Property(e => e.Frequency).HasMaxLength(50);
            entity.Property(e => e.Memo).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Reinsurance>(entity =>
        {
            entity.ToTable("Reinsurance");

            entity.Property(e => e.ReinsuranceId).HasColumnName("ReinsuranceID");
            entity.Property(e => e.ApplicantsIds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ApplicantsIDs");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FPRs");
            entity.Property(e => e.RiskCheck)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReinsuranceDetail>(entity =>
        {
            entity.HasKey(e => e.SlNo);

            entity.HasIndex(e => e.Company, "indx_ReinsuranceDetails_Company");

            entity.HasIndex(e => new { e.Fprid, e.Company }, "indx_ReinsuranceDetails_FPRId_Company").HasFillFactor(90);

            entity.Property(e => e.ApplicantName).IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsuranceDetailsAlt>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasFillFactor(90);

            entity.ToTable("ReinsuranceDetailsAlt");

            entity.Property(e => e.ApplicantName).IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExecutionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SummaryId).HasDefaultValue(0);
        });

        modelBuilder.Entity<ReinsuranceDetailsAltBkp12052024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReinsuranceDetailsAlt_BKP12052024");

            entity.Property(e => e.ApplicantName).IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExecutionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReinsuranceDetailsBkp12052024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReinsuranceDetails_BKP12052024");

            entity.Property(e => e.ApplicantName).IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Occupation).IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReinsuranceDetailsTable>(entity =>
        {
            entity.HasKey(e => e.ReinsuranceDetailId);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsuranceExtraPremium>(entity =>
        {
            entity.ToTable("ReinsuranceExtraPremium");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReinsurancePaymentCheck>(entity =>
        {
            entity.HasKey(e => e.ReinsurancePaymentId);

            entity.ToTable("ReinsurancePaymentCheck");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.NthYear).HasDefaultValue(1);
            entity.Property(e => e.ReinsurancePayStatus).HasDefaultValue(0);
        });

        modelBuilder.Entity<ReinsurancePremiumRate>(entity =>
        {
            entity.ToTable("ReinsurancePremiumRate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReinsuranceType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsuranceProcess>(entity =>
        {
            entity.ToTable("ReinsuranceProcess");

            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.Msg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("msg");
        });

        modelBuilder.Entity<ReinsuranceRegister>(entity =>
        {
            entity.HasKey(e => e.RegisterId).HasFillFactor(90);

            entity.ToTable("ReinsuranceRegister");

            entity.Property(e => e.Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsuranceRegisterDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReinsuranceRegisterDetail");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Document)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DocumentId).ValueGeneratedOnAdd();
            entity.Property(e => e.DocumentTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsuranceSummary>(entity =>
        {
            entity.HasKey(e => e.SummaryId).HasFillFactor(90);

            entity.ToTable("ReinsuranceSummary");

            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsuranceSupplementaryRate>(entity =>
        {
            entity.HasKey(e => e.ReinsuranceSuppId);

            entity.ToTable("ReinsuranceSupplementaryRate");

            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReinsuranceType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsuranceSupplementaryRateBkp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReinsuranceSupplementaryRate_BKP");

            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReinsuranceSuppId).ValueGeneratedOnAdd();
            entity.Property(e => e.ReinsuranceType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReinsurencePerPolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyReInsId);

            entity.ToTable("ReinsurencePerPolicy");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RenewalPercentage>(entity =>
        {
            entity.ToTable("RenewalPercentage");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RenewalPercentage1).HasColumnName("RenewalPercentage");
        });

        modelBuilder.Entity<RequisitionAudit>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Requisition_Audit");

            entity.Property(e => e.Sl)
                .ValueGeneratedNever()
                .HasColumnName("SL");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ResumeCollection>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ResumeCollection");

            entity.Property(e => e.ResumeReceivingDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RfDailyAttendance>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("RF_DailyAttendance");

            entity.HasIndex(e => e.UserId, "UserId_RF_DailyAttendance_Idx").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.LogInTime).HasColumnType("datetime");
            entity.Property(e => e.LogOutTime).HasColumnType("datetime");
            entity.Property(e => e.Rfid).HasColumnName("RFID");
            entity.Property(e => e.SensorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.UserType).IsUnicode(false);
        });

        modelBuilder.Entity<RfTempDailyAttendance>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("RF_Temp_DailyAttendance", tb => tb.HasTrigger("InsertInto_RF_DailyAttendance"));

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.LogTime).HasColumnType("datetime");
            entity.Property(e => e.Rfid).HasColumnName("RFID");
            entity.Property(e => e.UserType).IsUnicode(false);
        });

        modelBuilder.Entity<RfidReader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RfidReader2020");

            entity.ToTable("RfidReader");

            entity.Property(e => e.LocalTime).HasColumnType("datetime");
            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NUserId).HasColumnName("nUserId");
            entity.Property(e => e.Rfid).HasColumnName("RFID");
        });

        modelBuilder.Entity<RptAgentOr>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("RPT_AgentOR");

            entity.HasIndex(e => e.AgentId, "idxAgentId").HasFillFactor(90);

            entity.HasIndex(e => e.Amdid, "idxSamdId").HasFillFactor(90);

            entity.HasIndex(e => e.UserName, "idxUserName").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Agent).IsUnicode(false);
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.Bcid).HasColumnName("BCId");
            entity.Property(e => e.Bmid).HasColumnName("BMID");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCId");
            entity.Property(e => e.Faid).HasColumnName("FAID");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.Umid).HasColumnName("UMID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RptExpectedRenewal>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("RPT_ExpectedRenewal");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.Bcid).HasColumnName("BCId");
            entity.Property(e => e.Bmid).HasColumnName("BMID");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCId");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.Umid).HasColumnName("UMID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RptLapseSamd>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("RPT_LapseSAMD");

            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.Bcid).HasColumnName("BCId");
            entity.Property(e => e.Bmid).HasColumnName("BMID");
            entity.Property(e => e.Dcid).HasColumnName("DCId");
            entity.Property(e => e.Dvcid).HasColumnName("DVCId");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Fprid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FPRID");
            entity.Property(e => e.Rcid).HasColumnName("RCId");
            entity.Property(e => e.Samdid).HasColumnName("SAMDID");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.Umid).HasColumnName("UMID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalaryAdjust2025>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("SalaryAdjust2025");

            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PayStatus).HasDefaultValue(0);
        });

        modelBuilder.Entity<SalaryCalculation>(entity =>
        {
            entity.HasKey(e => e.CalSalId).HasFillFactor(90);

            entity.ToTable("SalaryCalculation");

            entity.Property(e => e.CalSalId).HasColumnName("CalSalID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EducationalQualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Increment).HasDefaultValue(0.0);
            entity.Property(e => e.IncrementCounter).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SbclaimPaid2022>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("SBClaimPaid2022");

            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.InsNo).HasDefaultValue(0);
        });

        modelBuilder.Entity<SessionLoginHistory>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__SessionL__5E548648150E57A3");

            entity.ToTable("SessionLoginHistory", "Admin");

            entity.Property(e => e.ClientNetAddress).HasMaxLength(100);
            entity.Property(e => e.HostName).HasMaxLength(50);
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.LogoutTime).HasColumnType("datetime");
            entity.Property(e => e.ProgramName).HasMaxLength(500);
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<SetNotification>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("SetNotification");

            entity.Property(e => e.AccountHolderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationFrequency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prdate).HasColumnName("PRDate");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserToNotify).IsUnicode(false);
        });

        modelBuilder.Entity<ShareDetail>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fv)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FV");
            entity.Property(e => e.MasterId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ShareHolderId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TransactionVal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TransferParty).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<ShareHolderEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("ShareHolderEntry");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BuyQty).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CashQty).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FV");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SellQty).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StockQty).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TotalValue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShareHolderName>(entity =>
        {
            entity.ToTable("ShareHolderName");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShareHolderType>(entity =>
        {
            entity.ToTable("ShareHolderType");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ShareTransfer>(entity =>
        {
            entity.ToTable("ShareTransfer");

            entity.Property(e => e.NewActCode).HasMaxLength(50);
            entity.Property(e => e.OldActCode).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Smrneeded>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMRNeeded");

            entity.Property(e => e.Bmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Erpstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ERPStatus");
            entity.Property(e => e.ExecutiveName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remake)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Tid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TID");
        });

        modelBuilder.Entity<Smrupdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("SMRUpdate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TrxnId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TrxnID");
        });

        modelBuilder.Entity<SmsLog>(entity =>
        {
            entity.HasKey(e => e.Smsid).HasName("PK_SmsLog1");

            entity.ToTable("SmsLog", tb => tb.HasTrigger("InsertIntoSSLDB1"));

            entity.HasIndex(e => e.ResponseText, "InsuranceDB_SQLOPS_SmsLog_2373688_2373687").HasFillFactor(90);

            entity.HasIndex(e => e.Fprid, "InsuranceDB_SQLOPS_SmsLog_257299_257298").HasFillFactor(90);

            entity.Property(e => e.Smsid).HasColumnName("SMSId");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditBalance)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.MessageId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OptrTxnId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OptrTxnID");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .IsUnicode(false)
                .HasDefaultValueSql("((CONVERT([nvarchar],getdate(),(112))+replace(CONVERT([nvarchar],getdate(),(114)),':',''))+CONVERT([nvarchar],round(rand()*(100),(0))))")
                .HasColumnName("ReferenceID");
            entity.Property(e => e.ResponseText)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmsLogJune>(entity =>
        {
            entity.HasKey(e => e.Smsid).HasName("PK_SmsLog");

            entity.ToTable("SmsLog_June", tb => tb.HasTrigger("InsertIntoSSLDB"));

            entity.HasIndex(e => e.Fprid, "FprId_SmsLog_Idx").HasFillFactor(90);

            entity.HasIndex(e => e.CreateDate, "IDX_SmsLog_CDate");

            entity.HasIndex(e => e.PhoneNo, "IDX_SmsLog_Phn_CDate");

            entity.HasIndex(e => e.ResponseText, "IDX_SmsLog_Res_Mes_Phn_Cdate");

            entity.HasIndex(e => e.ResponseText, "IDX_Smslog_ResponsText");

            entity.HasIndex(e => e.SmsType, "NonClusteredIndex-20200106-171020").HasFillFactor(90);

            entity.HasIndex(e => e.PurposeId, "PurposeId_SmsLog_Idx");

            entity.Property(e => e.Smsid).HasColumnName("SMSId");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditBalance)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.MessageId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .IsUnicode(false)
                .HasDefaultValueSql("((CONVERT([nvarchar],getdate(),(112))+replace(CONVERT([nvarchar],getdate(),(114)),':',''))+CONVERT([nvarchar],round(rand()*(100),(0))))")
                .HasColumnName("ReferenceID");
            entity.Property(e => e.ResponseText)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmsPurpose>(entity =>
        {
            entity.HasKey(e => e.PurposeId);

            entity.ToTable("SmsPurpose");

            entity.Property(e => e.PurposeName).IsUnicode(false);
        });

        modelBuilder.Entity<SpecialPermissionAgent>(entity =>
        {
            entity.ToTable("SpecialPermissionAgent");
        });

        modelBuilder.Entity<SqlQuery052020>(entity =>
        {
            entity.ToTable("SqlQuery052020");

            entity.Property(e => e.Application)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Sqlmapoutput>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sqlmapou__3213E83F8C24D09A");

            entity.ToTable("sqlmapoutput");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasMaxLength(4000)
                .HasColumnName("data");
        });

        modelBuilder.Entity<SslSm>(entity =>
        {
            entity.ToTable("sslSms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mobno)
                .IsUnicode(false)
                .HasColumnName("mobno");
            entity.Property(e => e.Msg)
                .IsUnicode(false)
                .HasColumnName("msg");
            entity.Property(e => e.Refid)
                .IsUnicode(false)
                .HasColumnName("refid");
            entity.Property(e => e.Smsdate)
                .HasColumnType("datetime")
                .HasColumnName("smsdate");
            entity.Property(e => e.Smsstatus)
                .IsUnicode(false)
                .HasColumnName("smsstatus");
        });

        modelBuilder.Entity<StatementOfKeyFinancialIndicato>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("StatementOfKeyFinancialIndicato$");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AmountInMillionBdt)
                .HasMaxLength(255)
                .HasColumnName("Amount in Million (BDT)");
            entity.Property(e => e.F10).HasMaxLength(255);
            entity.Property(e => e.F2).HasMaxLength(255);
            entity.Property(e => e.F4).HasMaxLength(255);
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.F8).HasMaxLength(255);
            entity.Property(e => e.F9).HasMaxLength(255);
            entity.Property(e => e.Particulars).HasMaxLength(255);
            entity.Property(e => e.SlNo).HasColumnName("Sl No#");
        });

        modelBuilder.Entity<StipendBankDetail>(entity =>
        {
            entity.HasKey(e => e.BankDetailId);

            entity.Property(e => e.BankDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AcbranchName)
                .IsUnicode(false)
                .HasColumnName("ACBranchName");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AcholderName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACHolderName");
            entity.Property(e => e.Actype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACType");
            entity.Property(e => e.BankAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClaimId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FprId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NameOfBank)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StoreCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("StoreCategory");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StoreItem>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasFillFactor(90);

            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StoreItemsIn>(entity =>
        {
            entity.HasKey(e => e.InId);

            entity.ToTable("StoreItemsIn");

            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<StoreItemsOut>(entity =>
        {
            entity.HasKey(e => e.OutId);

            entity.ToTable("StoreItemsOut");

            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IssueFor).IsUnicode(false);
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<StoreMaster>(entity =>
        {
            entity.HasKey(e => e.StoreMasterId).HasFillFactor(90);

            entity.ToTable("StoreMaster");
        });

        modelBuilder.Entity<StorePurchaseRec>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("StorePurchaseRec");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SubGroupCategory>(entity =>
        {
            entity.HasKey(e => e.SubGroupCatId);

            entity.ToTable("SubGroupCategory");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SubGroupCatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SupplementaryClaimApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("SupplementaryClaimApplication");

            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankAcno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BankACno");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankRoutineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BlankCheckOrBankStatementFileName).IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiagnosticOrInvestigationOrPathoplogicalReport).IsUnicode(false);
            entity.Property(e => e.DoctorPrescription).IsUnicode(false);
            entity.Property(e => e.HospitalBills).IsUnicode(false);
            entity.Property(e => e.HospitalDischargeCertificate).IsUnicode(false);
            entity.Property(e => e.ImagingReports).IsUnicode(false);
            entity.Property(e => e.NameOfPolicyHolder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NatureOfAccidentOrSickness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlaceOfAccidentOrSickness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).IsUnicode(false);
            entity.Property(e => e.PresentAddressOfPolicyHolder).IsUnicode(false);
            entity.Property(e => e.TimeOfAccident)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfAccidentOrSickness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfClaim)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SupplimentryCombination>(entity =>
        {
            entity.ToTable("SupplimentryCombination");
        });

        modelBuilder.Entity<SurrenderAnalytic>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Year, e.MonthNo }).HasName("PK_SurrenderAnalytic_1");

            entity.ToTable("SurrenderAnalytic");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Amd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMD");
            entity.Property(e => e.Bm)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BM");
            entity.Property(e => e.Branch)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fa).HasColumnName("FA");
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.Products)
                .HasMaxLength(261)
                .IsUnicode(false);
            entity.Property(e => e.Samd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAMD");
            entity.Property(e => e.Sgm)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SGM");
            entity.Property(e => e.Um)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UM");
        });

        modelBuilder.Entity<SurveillanceCamara>(entity =>
        {
            entity.HasKey(e => e.SurveillanceId);

            entity.ToTable("SurveillanceCamara");

            entity.Property(e => e.CamaraName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CamaraUrl).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Tbl1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl1");

            entity.Property(e => e.FdrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tbl2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl2");

            entity.Property(e => e.FdrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblChart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblChart");

            entity.Property(e => e.Gcode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("GCode");
            entity.Property(e => e.Gname)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Sgcode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SGCode");
            entity.Property(e => e.Sgname)
                .IsUnicode(false)
                .HasColumnName("SGName");
        });

        modelBuilder.Entity<TblFpr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblFPR");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TeamDeed>(entity =>
        {
            entity.ToTable("TeamDeed");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TeamName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TeamLeaderClaim>(entity =>
        {
            entity.ToTable("TeamLeaderClaim");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TeamLeaderEntry>(entity =>
        {
            entity.ToTable("TeamLeaderEntry");

            entity.Property(e => e.Amdid).HasColumnName("AMDId");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Samdid).HasColumnName("SAMDId");
            entity.Property(e => e.Sgmid).HasColumnName("SGMId");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TeamMemberClaim>(entity =>
        {
            entity.ToTable("TeamMemberClaim");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempAgentSalary>(entity =>
        {
            entity.HasKey(e => e.AgentSalaryId);

            entity.ToTable("TempAgentSalary");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeductionDescription).IsUnicode(false);
        });

        modelBuilder.Entity<TempApplicantFamilyHistoryTbl>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_TempApplicantFamilyHistoryTbl2020")
                .HasFillFactor(90);

            entity.ToTable("TempApplicantFamilyHistoryTbl");

            entity.Property(e => e.AgeDuringDeath)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CurrPhysicalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeathReason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DurationOfIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fhage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FHAge");
            entity.Property(e => e.LifeStatus)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Relation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UniqueNumber).IsUnicode(false);
            entity.Property(e => e.YearOfDeath)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempApplicantNomineeTbl>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("TempApplicantNomineeTbl");

            entity.Property(e => e.Sl).HasColumnName("sl");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.NomineeAge)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAllocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeDob).HasColumnName("NomineeDOB");
            entity.Property(e => e.NomineeGuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineePpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NomineePPName");
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UniqueNumber).IsUnicode(false);
            entity.Property(e => e.UploadDocument)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempDailyExpense>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("TempDailyExpense");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AdvRent).HasColumnName("advRent");
            entity.Property(e => e.AdvRentAcc)
                .IsUnicode(false)
                .HasColumnName("advRentAcc");
            entity.Property(e => e.AgentId).HasMaxLength(50);
            entity.Property(e => e.AgentType).HasMaxLength(50);
            entity.Property(e => e.BankAc)
                .IsUnicode(false)
                .HasColumnName("BankAC");
            entity.Property(e => e.BankCash)
                .IsUnicode(false)
                .HasColumnName("bankCash");
            entity.Property(e => e.Branch).IsUnicode(false);
            entity.Property(e => e.ChequeId).HasMaxLength(50);
            entity.Property(e => e.ChequeNo).IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.ExpenseDate).IsUnicode(false);
            entity.Property(e => e.ExpenseType).IsUnicode(false);
            entity.Property(e => e.ExpenseTypeId).IsUnicode(false);
            entity.Property(e => e.PayType).IsUnicode(false);
            entity.Property(e => e.VoucherNo).IsUnicode(false);
        });

        modelBuilder.Entity<TempPolicyToDeed>(entity =>
        {
            entity.ToTable("TempPolicyToDeed");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprdate).HasColumnName("FPRDate");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
        });

        modelBuilder.Entity<Tempagent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempagent");

            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Test2>(entity =>
        {
            entity.ToTable("test2", tb =>
                {
                    tb.HasTrigger("trg_test2_DisableDelete");
                    tb.HasTrigger("ups");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dt");
            entity.Property(e => e.Updates)
                .IsUnicode(false)
                .HasColumnName("updates");
        });

        modelBuilder.Entity<TestAgentComCalcDetail>(entity =>
        {
            entity.HasKey(e => e.AgentComId);

            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Ic).HasColumnName("IC");
            entity.Property(e => e.Icbalance).HasColumnName("ICBalance");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TestAgentPerf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TestPerf");

            entity.ToTable("TestAgentPerf");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Agent)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CommencementDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepositDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Faumbm)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("FAUMBM");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NextPremiumDueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfPr)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Samd)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SAMD");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestAgentperfad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Testperfad");

            entity.ToTable("TestAgentperfad");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Agent)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CommencementDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepositDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Faumbm)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("FAUMBM");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NextPremiumDueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfPr)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Samd)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SAMD");
            entity.Property(e => e.TableAndTerm)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestChartRate>(entity =>
        {
            entity.ToTable("TestChartRate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllowableExpenseAgency).HasColumnName("AllowableExpense_Agency");
            entity.Property(e => e.AllowableExpenseMgmt).HasColumnName("AllowableExpense_Mgmt");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestDataInsertUpdateDelete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TestData__3213E83F325CF33E");

            entity.ToTable("TestDataInsertUpdateDelete");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Empaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empaddress");
            entity.Property(e => e.Empname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Hiredate).HasColumnName("hiredate");
            entity.Property(e => e.Updatedon)
                .HasColumnType("datetime")
                .HasColumnName("updatedon");
        });

        modelBuilder.Entity<TestOnlinePay>(entity =>
        {
            entity.ToTable("TestOnlinePay");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fprid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fprid");
            entity.Property(e => e.TestVal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("testVal");
            entity.Property(e => e.UrlReferrer)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestQueue>(entity =>
        {
            entity.ToTable("TestQueue");

            entity.Property(e => e.Dt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dt");
            entity.Property(e => e.TestVal)
                .IsUnicode(false)
                .HasColumnName("testVal");
        });

        modelBuilder.Entity<Testz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("testz");

            entity.Property(e => e.Abc)
                .IsUnicode(false)
                .HasColumnName("abc");
        });

        modelBuilder.Entity<ThanaList>(entity =>
        {
            entity.ToTable("ThanaList");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThanaName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tinserted>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Tinserted");

            entity.Property(e => e.ActPrem).HasColumnType("money");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.OrentryDate).HasColumnName("OREntryDate");
            entity.Property(e => e.OrentryId).HasColumnName("OREntryId");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentPurpose)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TitasAgentTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TitasAgentTemp");

            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TmpAcc2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TmpAcc2");

            entity.Property(e => e.AccStatement).HasMaxLength(400);
        });

        modelBuilder.Entity<TmpAccChart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpAccChart");

            entity.Property(e => e.ActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Camount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CAmount");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DAmount");
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Year).HasMaxLength(8);
        });

        modelBuilder.Entity<TmpAccGlUmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpAccGL_UMP");

            entity.Property(e => e.AccStatement)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.ActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClaimId)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("ClaimID");
        });

        modelBuilder.Entity<TmpAgentForwardingError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpAgentForwardingError");

            entity.Property(e => e.AgentForwardingDetailsId).HasColumnName("AgentForwardingDetailsID");
            entity.Property(e => e.AgentForwardingMasterId).HasColumnName("AgentForwardingMasterID");
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bmid).HasColumnName("BMId");
            entity.Property(e => e.Bmname)
                .IsUnicode(false)
                .HasColumnName("BMName");
            entity.Property(e => e.Company)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Faid).HasColumnName("FAId");
            entity.Property(e => e.Faname)
                .IsUnicode(false)
                .HasColumnName("FAName");
            entity.Property(e => e.ForwardingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderName).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.Token)
                .HasMaxLength(119)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.TransectionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UmName).IsUnicode(false);
            entity.Property(e => e.Umid).HasColumnName("UMId");
        });

        modelBuilder.Entity<TmpBipulTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmpBipul__3214EC078100321E");

            entity.ToTable("tmpBipulTest");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TmpBkash>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpBKash");

            entity.Property(e => e.CouponAmount).HasMaxLength(255);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.FromAccountNumber).HasMaxLength(255);
            entity.Property(e => e.PostedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.ToAccountNumber).HasMaxLength(255);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionReference).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpBkash1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpBKash_1");

            entity.Property(e => e.CouponAmount).HasMaxLength(255);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionReference).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpBkash10>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpBKash_10");

            entity.Property(e => e.CouponAmount).HasMaxLength(255);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.FromAccountNumber).HasMaxLength(255);
            entity.Property(e => e.PostedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.ToAccountNumber).HasMaxLength(255);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionReference).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpBkash2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpBKash_2024");

            entity.Property(e => e.FromAccountNumber).HasMaxLength(255);
            entity.Property(e => e.Mobile).HasMaxLength(255);
            entity.Property(e => e.Reference).HasMaxLength(255);
            entity.Property(e => e.ToAccountNumber).HasMaxLength(255);
            entity.Property(e => e.TransectionDate).HasColumnType("datetime");
            entity.Property(e => e.TransectionId).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpBkashBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpBKash_bk");

            entity.Property(e => e.CouponAmount).HasMaxLength(255);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.FromAccountNumber).HasMaxLength(255);
            entity.Property(e => e.PostedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.ToAccountNumber).HasMaxLength(255);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionReference).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpBkashDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpBkashDelete");

            entity.Property(e => e.FromAccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reference).HasMaxLength(255);
            entity.Property(e => e.ToAccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransectionDate).HasColumnType("datetime");
            entity.Property(e => e.TransectionId).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpBkashError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpBkashError");

            entity.Property(e => e.FromAccountNumber).HasMaxLength(255);
            entity.Property(e => e.Reference).HasMaxLength(255);
            entity.Property(e => e.ToAccountNumber).HasMaxLength(255);
            entity.Property(e => e.TransectionDate).HasColumnType("datetime");
            entity.Property(e => e.TransectionId).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpClaimApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpClaimAPI");

            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.UmpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UMP_ID");
        });

        modelBuilder.Entity<TmpDeath>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpDeath");

            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClaimStatus).IsUnicode(false);
            entity.Property(e => e.ClaimType).IsUnicode(false);
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.MSl).HasColumnName("mSl");
            entity.Property(e => e.NoOfHoliday).HasColumnName("noOfHoliday");
            entity.Property(e => e.OcfreceivingDate).HasColumnName("OCFreceivingDate");
            entity.Property(e => e.PolicyNo).IsUnicode(false);
            entity.Property(e => e.SettlementDuration).HasMaxLength(50);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TmpIislog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpIISLogs", "Audt");

            entity.Property(e => e.CIp)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("c-ip");
            entity.Property(e => e.CsMethod)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("cs-method");
            entity.Property(e => e.CsReferer)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("cs(Referer)");
            entity.Property(e => e.CsUriQuery)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("cs-uri-query");
            entity.Property(e => e.CsUriStem)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cs-uri-stem");
            entity.Property(e => e.CsUserAgent)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("cs(User-Agent)");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.SIp)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("s-ip");
            entity.Property(e => e.SPort)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("s-port");
            entity.Property(e => e.SUsername)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("s-username");
            entity.Property(e => e.ScStatus).HasColumnName("sc-STATUS");
            entity.Property(e => e.ScSubstatus).HasColumnName("sc-substatus");
            entity.Property(e => e.ScWin32Status).HasColumnName("sc-win32-STATUS");
            entity.Property(e => e.Time).HasColumnName("TIME");
            entity.Property(e => e.TimeTaken).HasColumnName("time-taken");
        });

        modelBuilder.Entity<TmpInvalidClaimDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpInvalidClaimData");

            entity.Property(e => e.AccruedBonus).HasMaxLength(255);
            entity.Property(e => e.BankAccountName).HasMaxLength(255);
            entity.Property(e => e.BankAccountNo).HasMaxLength(255);
            entity.Property(e => e.BankBranchName).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BankRoutingNo).HasMaxLength(255);
            entity.Property(e => e.ClaimAmount).HasMaxLength(255);
            entity.Property(e => e.ClaimDate).HasMaxLength(255);
            entity.Property(e => e.ClaimNo).HasMaxLength(255);
            entity.Property(e => e.ClaimStatus).HasMaxLength(255);
            entity.Property(e => e.ClaimType).HasMaxLength(255);
            entity.Property(e => e.DateOfBirth).HasMaxLength(255);
            entity.Property(e => e.Deduction).HasMaxLength(255);
            entity.Property(e => e.DeductionCause).HasMaxLength(255);
            entity.Property(e => e.InstallmentNumber).HasMaxLength(255);
            entity.Property(e => e.InsuranceType).HasMaxLength(255);
            entity.Property(e => e.IntimationDate).HasMaxLength(255);
            entity.Property(e => e.IntimationNumber).HasMaxLength(255);
            entity.Property(e => e.MultiAccountInfo).HasMaxLength(255);
            entity.Property(e => e.MultiAccountPayment).HasMaxLength(255);
            entity.Property(e => e.NetPayable).HasMaxLength(255);
            entity.Property(e => e.NomineeInfo).HasMaxLength(255);
            entity.Property(e => e.PaymentDate).HasMaxLength(255);
            entity.Property(e => e.PaymentDetail).HasMaxLength(255);
            entity.Property(e => e.PaymentMethod).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.ReinsuranceClaimAmount).HasMaxLength(255);
            entity.Property(e => e.RiskStartDate).HasMaxLength(255);
            entity.Property(e => e.Suspense).HasMaxLength(255);
            entity.Property(e => e.TotalAmount).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TmpPolicy");
        });

        modelBuilder.Entity<TmpPolicyApplicantNominee>(entity =>
        {
            entity.HasKey(e => e.NomineeId);

            entity.ToTable("Tmp_PolicyApplicantNominee");

            entity.HasIndex(e => new { e.NomineeName, e.ApplicantId }, "Unique_Tmp_PolicyApplicantNominee").IsUnique();

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.NomineeAge)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAllocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeDob).HasColumnName("NomineeDOB");
            entity.Property(e => e.NomineeGuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineePpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NomineePPName");
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UploadDocument)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Applicant).WithMany(p => p.TmpPolicyApplicantNominees)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_Tmp_PolicyApplicantNominee_PolicyApplicantsPersonalInfo");
        });

        modelBuilder.Entity<TmpPolicyApplicantsFamilyHistory>(entity =>
        {
            entity.HasKey(e => e.FamilyHistoryId);

            entity.ToTable("Tmp_PolicyApplicantsFamilyHistory");

            entity.Property(e => e.Age)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgeDuringDeath)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CurrentPhysicalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeathReason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DurationOfLastIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LifeStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Relation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YearOfDeath)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Applicant).WithMany(p => p.TmpPolicyApplicantsFamilyHistories)
                .HasForeignKey(d => d.ApplicantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tmp_PolicyApplicantsFamilyHistory_PolicyApplicantsPersonalInfo");
        });

        modelBuilder.Entity<TmpPolicyApplicantsPersonalInfo>(entity =>
        {
            entity.HasKey(e => e.ApplicantId);

            entity.ToTable("Tmp_PolicyApplicantsPersonalInfo");

            entity.Property(e => e.Acc)
                .HasMaxLength(10)
                .HasDefaultValue("n")
                .IsFixedLength();
            entity.Property(e => e.AncestralDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantIdno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ApplicantIDNo");
            entity.Property(e => e.ApplicantMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantNameBang).HasMaxLength(500);
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPhotoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPpname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ApplicantPPName");
            entity.Property(e => e.ApplicantSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlace).IsUnicode(false);
            entity.Property(e => e.ChestSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPoxVaccin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentHeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentWeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentlyWell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EduQualification).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EpilepticProblem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EyeDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FrequentCough)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GoitrousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificationMark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InfectiousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LongHolidayForIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiltDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PhysicalDisability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SmsFormate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StomachInfection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypesOfOperation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnderWrittingComments).IsUnicode(false);
            entity.Property(e => e.UniqueKey).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UploadDocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UploadDocumentID");
            entity.Property(e => e.UrineStone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WaistSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeightLossOrGain)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenBaby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEarnAbility)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEduQualification).IsUnicode(false);
            entity.Property(e => e.WomenHusbandMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandName)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKids)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKidsExpectation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenLastPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenPayTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenSourceOfIncome)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Agent).WithMany(p => p.TmpPolicyApplicantsPersonalInfos)
                .HasPrincipalKey(p => p.AgentId)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("FK_Tmp_PolicyApplicantsPersonalInfo_AgentJobDetails");
        });

        modelBuilder.Entity<TmpPolicyApplicantsPolicyInfo>(entity =>
        {
            entity.HasKey(e => e.ApplicantPolicyId);

            entity.ToTable("Tmp_PolicyApplicantsPolicyInfo");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OtherDuePolicySli)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyAccpDate).HasColumnType("datetime");
            entity.Property(e => e.OtherPolicyCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyCondition)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyDuration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyRejectInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyPayee)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PolicyReason).IsUnicode(false);
            entity.Property(e => e.PolicyRiskAdditonalFactor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrBmNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceOfIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.YearlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ysapa).HasColumnName("YSAPA");

            entity.HasOne(d => d.Applicant).WithMany(p => p.TmpPolicyApplicantsPolicyInfos)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_Tmp_PolicyApplicantsPolicyInfo_PolicyApplicantsPersonalInfo");

            entity.HasOne(d => d.Policy).WithMany(p => p.TmpPolicyApplicantsPolicyInfos)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("FK_Tmp_PolicyApplicantsPolicyInfo_PolicyInfo");

            entity.HasOne(d => d.Supplimentry).WithMany(p => p.TmpPolicyApplicantsPolicyInfos)
                .HasForeignKey(d => d.SupplimentryId)
                .HasConstraintName("FK_Tmp_PolicyApplicantsPolicyInfo_PolicySupplimentryEntry");
        });

        modelBuilder.Entity<TmpPolicyFix>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tmp_PolicyFix");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Orentryid).HasColumnName("ORENTRYID");
            entity.Property(e => e.PostingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TmpReversionary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TmpReversionary");

            entity.Property(e => e.BonusAmt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpTransactionList>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tmpTransactionList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MonthOfYear)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionNo).HasMaxLength(100);
        });

        modelBuilder.Entity<TmpUmpClaimApiStatusHealth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpUMP_ClaimAPI_Status_Health");

            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ClaimType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FprId).HasColumnName("FPR_ID");
            entity.Property(e => e.PostingDate).HasColumnType("datetime");
            entity.Property(e => e.ResponseDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UmpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UMP_ID");
        });

        modelBuilder.Entity<TmpUmpclaimApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpUMPClaimAPI");

            entity.Property(e => e.AccruedBonus)
                .HasMaxLength(4000)
                .HasColumnName("accruedBonus");
            entity.Property(e => e.ClaimAmount)
                .HasMaxLength(4000)
                .HasColumnName("claimAmount");
            entity.Property(e => e.ClaimDate)
                .HasMaxLength(4000)
                .HasColumnName("claimDate");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimNo)
                .HasMaxLength(4000)
                .HasColumnName("claimNo");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(4000)
                .HasColumnName("claimStatus");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(4000)
                .HasColumnName("claimType");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(4000)
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.Deduction)
                .HasMaxLength(4000)
                .HasColumnName("deduction");
            entity.Property(e => e.DeductionCause)
                .HasMaxLength(4000)
                .HasColumnName("deductionCause");
            entity.Property(e => e.FprId).HasColumnName("FPR_ID");
            entity.Property(e => e.InstallmentNumber)
                .HasMaxLength(4000)
                .HasColumnName("installmentNumber");
            entity.Property(e => e.InsuranceType)
                .HasMaxLength(4000)
                .HasColumnName("insuranceType");
            entity.Property(e => e.IntimationDate)
                .HasMaxLength(4000)
                .HasColumnName("intimationDate");
            entity.Property(e => e.IntimationNumber)
                .HasMaxLength(4000)
                .HasColumnName("intimationNumber");
            entity.Property(e => e.NetPayable)
                .HasMaxLength(4000)
                .HasColumnName("netPayable");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(4000)
                .HasColumnName("policyNumber");
            entity.Property(e => e.PostingDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceClaimAmount)
                .HasMaxLength(4000)
                .HasColumnName("reinsuranceClaimAmount");
            entity.Property(e => e.ResponseDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RiskStartDate)
                .HasMaxLength(4000)
                .HasColumnName("riskStartDate");
            entity.Property(e => e.Suspense)
                .HasMaxLength(4000)
                .HasColumnName("suspense");
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(4000)
                .HasColumnName("totalAmount");
            entity.Property(e => e.UnsetteledReason)
                .HasMaxLength(4000)
                .HasColumnName("unsetteledReason");
        });

        modelBuilder.Entity<TmpUmpclaimErr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpUMPClaimErr");

            entity.Property(e => e.AccruedBonus).HasMaxLength(255);
            entity.Property(e => e.BankAccountName).HasMaxLength(255);
            entity.Property(e => e.BankAccountNo).HasMaxLength(255);
            entity.Property(e => e.BankBranchName).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BankRoutingNo).HasMaxLength(255);
            entity.Property(e => e.ClaimAmount).HasMaxLength(255);
            entity.Property(e => e.ClaimDate).HasMaxLength(255);
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimNo).HasMaxLength(255);
            entity.Property(e => e.ClaimStatus).HasMaxLength(255);
            entity.Property(e => e.ClaimType).HasMaxLength(255);
            entity.Property(e => e.DateOfBirth).HasMaxLength(255);
            entity.Property(e => e.Deduction).HasMaxLength(255);
            entity.Property(e => e.DeductionCause).HasMaxLength(255);
            entity.Property(e => e.InstallmentNumber).HasMaxLength(255);
            entity.Property(e => e.InsuranceType).HasMaxLength(255);
            entity.Property(e => e.IntimationDate).HasMaxLength(255);
            entity.Property(e => e.IntimationNumber).HasMaxLength(255);
            entity.Property(e => e.MultiAccountInfo).HasMaxLength(255);
            entity.Property(e => e.MultiAccountPayment).HasMaxLength(255);
            entity.Property(e => e.NetPayable).HasMaxLength(255);
            entity.Property(e => e.NomineeInfo).HasMaxLength(255);
            entity.Property(e => e.PaymentDate).HasMaxLength(255);
            entity.Property(e => e.PaymentDetail).HasMaxLength(255);
            entity.Property(e => e.PaymentMethod).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.ReinsuranceClaimAmount).HasMaxLength(255);
            entity.Property(e => e.RiskStartDate).HasMaxLength(255);
            entity.Property(e => e.Suspense).HasMaxLength(255);
            entity.Property(e => e.TotalAmount).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpUmpclaimError>(entity =>
        {
            entity.ToTable("tmpUMPClaimError");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ClaimType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FprId).HasColumnName("FPR_ID");
            entity.Property(e => e.IsSend).HasDefaultValue((byte)0);
            entity.Property(e => e.PostingDate).HasColumnType("datetime");
            entity.Property(e => e.ResponseDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UmpId).HasColumnName("UMP_ID");
        });

        modelBuilder.Entity<TmpUmpdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpUMPData");

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpUmpinvalidPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpUMPInvalidPolicy");

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.AgentName).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateofBirth).HasColumnType("datetime");
            entity.Property(e => e.DepositDate).HasColumnType("datetime");
            entity.Property(e => e.DepositedToAcnumber)
                .HasMaxLength(255)
                .HasColumnName("DepositedToACNumber");
            entity.Property(e => e.DepositedToBank).HasMaxLength(255);
            entity.Property(e => e.DepositedToBranch).HasMaxLength(255);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Mfs)
                .HasMaxLength(255)
                .HasColumnName("MFS");
            entity.Property(e => e.Mfsacnumber)
                .HasMaxLength(255)
                .HasColumnName("MFSACNumber");
            entity.Property(e => e.NextPremiumDueDate).HasColumnType("datetime");
            entity.Property(e => e.OfficeBranchName).HasMaxLength(255);
            entity.Property(e => e.Ordate)
                .HasColumnType("datetime")
                .HasColumnName("ORDate");
            entity.Property(e => e.Orid).HasColumnName("ORID");
            entity.Property(e => e.OrsrNumber).HasColumnName("ORSrNumber");
            entity.Property(e => e.Ortype)
                .HasMaxLength(255)
                .HasColumnName("ORType");
            entity.Property(e => e.PaymentDetail).HasMaxLength(255);
            entity.Property(e => e.PaymentMode).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.Prdate)
                .HasColumnType("datetime")
                .HasColumnName("PRDate");
            entity.Property(e => e.PremiumMode).HasMaxLength(255);
            entity.Property(e => e.Prid).HasColumnName("PRID");
            entity.Property(e => e.ProjectCode).HasMaxLength(255);
            entity.Property(e => e.RiskStartDate).HasColumnType("datetime");
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<TmpUmppolicyError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpUMPPolicyError");

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TourBudget>(entity =>
        {
            entity.ToTable("TourBudget");

            entity.Property(e => e.TourBudgetId).HasColumnName("TourBudgetID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.TourId).HasColumnName("TourID");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TourPlan>(entity =>
        {
            entity.HasKey(e => e.TravelId);

            entity.ToTable("TourPlan");

            entity.Property(e => e.TravelId).HasColumnName("TravelID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BranchID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Place)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName).IsUnicode(false);
            entity.Property(e => e.Purpose).IsUnicode(false);
            entity.Property(e => e.TourId).HasColumnName("TourID");
            entity.Property(e => e.Trasport)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrailUse>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TrailUses)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrainingSchedule>(entity =>
        {
            entity.HasKey(e => e.TrainingId).HasFillFactor(90);

            entity.ToTable("TrainingSchedule");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FromTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParticipantAgentId).IsUnicode(false);
            entity.Property(e => e.ParticipantAgentName).IsUnicode(false);
            entity.Property(e => e.ParticipantEmpId).IsUnicode(false);
            entity.Property(e => e.ParticipantEmpName).IsUnicode(false);
            entity.Property(e => e.ToTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Trainer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TrainingSubject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).IsUnicode(false);
            entity.Property(e => e.Venue)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tran>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TansId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tansId");
            entity.Property(e => e.Test)
                .HasColumnType("datetime")
                .HasColumnName("test");
        });

        modelBuilder.Entity<Traning>(entity =>
        {
            entity.ToTable("Traning");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.TraningContent)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TraningQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId);

            entity.ToTable("TraningQuestion");

            entity.Property(e => e.Answer1).HasMaxLength(200);
            entity.Property(e => e.Answer2).HasMaxLength(200);
            entity.Property(e => e.Answer3).HasMaxLength(200);
            entity.Property(e => e.Answer4).HasMaxLength(200);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransactionCheck");

            entity.Property(e => e.Getwaytype)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TransationId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TransationID");
        });

        modelBuilder.Entity<TransferHistory>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("TransferHistory");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Df).HasColumnName("df");
            entity.Property(e => e.Dt).HasColumnName("dt");
        });

        modelBuilder.Entity<Trash>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("trash");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Smt)
                .HasMaxLength(500)
                .HasColumnName("smt");
        });

        modelBuilder.Entity<TrialBalByUser>(entity =>
        {
            entity.ToTable("TrialBalByUser");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ActTest)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camt)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CAmt");
            entity.Property(e => e.Damt)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DAmt");
            entity.Property(e => e.Ed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ed");
            entity.Property(e => e.FinalBal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.OpBal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sd");
        });

        modelBuilder.Entity<TrialBalSubGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TrialBalSubGroup");

            entity.Property(e => e.ActCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<TrnDelete072223>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRnDELETE072223");

            entity.Property(e => e.Fprid).HasColumnName("FPRID");
            entity.Property(e => e.Orentryid).HasColumnName("ORENTRYID");
            entity.Property(e => e.TrnId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TrnID");
        });

        modelBuilder.Entity<TrnDelete072223V2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRnDELETE072223_V2");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FprId).HasColumnName("FprID");
            entity.Property(e => e.OrEntryId).HasColumnName("OrEntryID");
            entity.Property(e => e.PTotalPolicyAmount).HasColumnName("P_TotalPolicyAmount");
            entity.Property(e => e.PYsapa).HasColumnName("P_ysapa");
            entity.Property(e => e.QuId)
                .ValueGeneratedOnAdd()
                .HasColumnName("QuID");
            entity.Property(e => e.TrnId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TrnID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UmpAllMismatch10252023>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("UMP_All_Mismatch_10252023");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<UmpClaimApiStatus>(entity =>
        {
            entity.HasKey(e => e.UmpId).HasFillFactor(90);

            entity.ToTable("UMP_ClaimAPI_Status");

            entity.Property(e => e.UmpId).HasColumnName("UMP_ID");
            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("initiate");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FprId).HasColumnName("FPR_ID");
            entity.Property(e => e.PostingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RequestStatus).HasComment("0=Default; 1=Success; 2=Error");
            entity.Property(e => e.ResponseDate)
                .HasComment("1=ClaimMaster Table; 2=MaturityClaimProcess Table; 3=ClaimStagePaymentList Table")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<UmpModifiedDatum>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("UMP_ModifiedData");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UmrahTour2023>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("UmrahTour2023");

            entity.Property(e => e.AgentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AgentTypeShort)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImageName).IsUnicode(false);
        });

        modelBuilder.Entity<UnionList>(entity =>
        {
            entity.ToTable("UnionList");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UpDocLapse>(entity =>
        {
            entity.HasKey(e => e.Sl).HasFillFactor(90);

            entity.ToTable("UpDoc_Lapse");

            entity.HasIndex(e => new { e.Fprid, e.Npdd }, "FprId_NPDD_UpDoc_Lapse_Idx").HasFillFactor(90);

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DghdocName)
                .IsUnicode(false)
                .HasColumnName("DGHDocName");
            entity.Property(e => e.MedDocName).IsUnicode(false);
            entity.Property(e => e.Npdd).HasColumnName("NPDD");
            entity.Property(e => e.ReqFlag)
                .HasDefaultValue(1)
                .HasColumnName("reqFlag");
            entity.Property(e => e.SysDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UpdateAgentComCalcDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Acc).HasMaxLength(50);
            entity.Property(e => e.AgentTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fprid).HasColumnName("FPRId");
            entity.Property(e => e.Ic).HasColumnName("IC");
            entity.Property(e => e.Icbalance).HasColumnName("ICBalance");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prnumber).HasColumnName("PRNumber");
            entity.Property(e => e.Rc).HasColumnName("RC");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UpdateDeleteHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("UpdateDeleteHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comments)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UdtypeId).HasColumnName("UDTypeID");
        });

        modelBuilder.Entity<UpdateDeleteType>(entity =>
        {
            entity.ToTable("UpdateDeleteType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Spname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SPName");
            entity.Property(e => e.Udtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UDType");
        });

        modelBuilder.Entity<UpdatedPendingRequestPolicy05302024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UpdatedPendingRequestPolicy_05302024");

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
        });

        modelBuilder.Entity<UploadFile>(entity =>
        {
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileName).IsUnicode(false);
            entity.Property(e => e.FileType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusFlag)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserCashLimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCash__3214EC271499E521");

            entity.ToTable("UserCashLimit");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserFromOnline>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UserFromOnline");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserHistory>(entity =>
        {
            entity.ToTable("UserHistory");

            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.LogIn).HasColumnType("datetime");
            entity.Property(e => e.LogOut).HasColumnType("datetime");
            entity.Property(e => e.TypeName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<UserLog>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("UserLog");

            entity.Property(e => e.Sl).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Dt)
                .HasColumnType("datetime")
                .HasColumnName("dt");
            entity.Property(e => e.Ip)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Pass)
                .HasMaxLength(500)
                .HasColumnName("pass");
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<UserTask>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK_UserTask_1");

            entity.ToTable("UserTask");

            entity.HasIndex(e => new { e.RelationId, e.CaseType }, "InsuranceDB_SQLOPS_UserTask_2378660_2378659").HasFillFactor(90);

            entity.HasIndex(e => new { e.UserName, e.CuStatus, e.ReadFlag }, "InsuranceDB_SQLOPS_UserTask_9_8").HasFillFactor(90);

            entity.HasIndex(e => new { e.CreateBy, e.ReadFlag }, "indx_UserTask_CreateBy_ReadFlag").HasFillFactor(90);

            entity.Property(e => e.CaseType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commence).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CuStatus).HasDefaultValue(0);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.ReadFlag).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserTaskOld>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK_UserTask");

            entity.ToTable("UserTaskOld");

            entity.HasIndex(e => e.CreateBy, "CreateBy_UserTask_Idx");

            entity.HasIndex(e => e.CreateDate, "CreateDate_UserTask_Idx");

            entity.HasIndex(e => e.ReadFlag, "ReadFlag_UserTask_Idx");

            entity.HasIndex(e => e.UserName, "UserName_UserTask_Idx");

            entity.HasIndex(e => e.CaseType, "aCase");

            entity.HasIndex(e => e.RelationId, "aaRel").IsDescending();

            entity.HasIndex(e => e.CuStatus, "status_UserTask");

            entity.Property(e => e.CaseType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commence).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CuStatus).HasDefaultValue(0);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.ReadFlag).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserTempLog>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_UserTepmLog")
                .HasFillFactor(90);

            entity.ToTable("UserTempLog", tb =>
                {
                    tb.HasTrigger("ChatRoomDelRefresh");
                    tb.HasTrigger("ChatRoomInsRefresh");
                });

            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.LastTime).HasColumnType("datetime");
            entity.Property(e => e.LogIn).HasColumnType("datetime");
            entity.Property(e => e.TypeName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<VacancyList>(entity =>
        {
            entity.ToTable("VacancyList");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VacancyTitle)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VehicleEmiPayment>(entity =>
        {
            entity.HasKey(e => e.EmiPaymentId).HasFillFactor(90);

            entity.ToTable("VehicleEmiPayment");

            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VehicleMaintenance>(entity =>
        {
            entity.ToTable("VehicleMaintenance");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.RegistationNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusFlag).HasDefaultValue(0);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VehicleOnEmi>(entity =>
        {
            entity.HasKey(e => e.VehicleEmiId).HasFillFactor(90);

            entity.ToTable("VehicleOnEMI");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag).HasDefaultValue(1);
            entity.Property(e => e.RegistrationNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Vendor");

            entity.Property(e => e.Adderss)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BinNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BIN_NO");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dateline).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProcCategoryId).HasColumnName("ProcCategoryID");
            entity.Property(e => e.TinNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIN_NO");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VendorCategory>(entity =>
        {
            entity.ToTable("VendorCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");
        });

        modelBuilder.Entity<VendorEnlistmentList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VendorEnlistmentList");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("Address ");
            entity.Property(e => e.Binno)
                .HasMaxLength(255)
                .HasColumnName("BINNo");
            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ContractNo)
                .HasMaxLength(255)
                .HasColumnName("ContractNo ");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SlNo).HasColumnName("SlNo ");
            entity.Property(e => e.Tinno)
                .HasMaxLength(255)
                .HasColumnName("TINNo");
        });

        modelBuilder.Entity<VendorItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VirtualAgentAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VartualAgentAnswer");

            entity.ToTable("VirtualAgentAnswer");

            entity.Property(e => e.Answer).IsUnicode(false);
            entity.Property(e => e.UserToken)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VirtualAgentQuestion>(entity =>
        {
            entity.ToTable("VirtualAgentQuestion");

            entity.Property(e => e.AnsType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QuestionSl).HasColumnName("QuestionSL");
            entity.Property(e => e.TitleEn).IsUnicode(false);
        });

        modelBuilder.Entity<VisitorCount>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("VisitorCount");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IP");
        });

        modelBuilder.Entity<VisitorLog>(entity =>
        {
            entity.HasKey(e => e.VisitId).HasFillFactor(90);

            entity.ToTable("VisitorLog");

            entity.Property(e => e.VisitId).HasColumnName("VisitID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FromTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Purpose).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VisitorAddress).IsUnicode(false);
            entity.Property(e => e.VisitorCompany).IsUnicode(false);
            entity.Property(e => e.VisitorMobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAllowableExpenseRateChart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_AllowableExpenseRateChart", "Expenses");

            entity.Property(e => e.AllowableExpenseAgency).HasColumnName("AllowableExpense(Agency)");
            entity.Property(e => e.AllowableExpenseMgmt)
                .HasMaxLength(4000)
                .HasColumnName("AllowableExpense(Mgmt)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebApplicant>(entity =>
        {
            entity.ToTable("WebApplicant");

            entity.Property(e => e.WebApplicantId).HasColumnName("WebApplicantID");
            entity.Property(e => e.AncestralDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentName).IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantNameBang).HasMaxLength(500);
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPhotoName).IsUnicode(false);
            entity.Property(e => e.ApplicantSpouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationSource).IsUnicode(false);
            entity.Property(e => e.BankAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlace).IsUnicode(false);
            entity.Property(e => e.ChestSizeAfter)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChestSizeBefore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChikenPoxVaccin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentHeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentWeight)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentlyWell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.EduQualification).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EpilepticProblem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EyeDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FrequentCough)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GoitrousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificationMark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InfectiousDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsPolicy).HasColumnName("isPolicy");
            entity.Property(e => e.Lien).HasDefaultValue(0);
            entity.Property(e => e.LienTerm).HasDefaultValue(0);
            entity.Property(e => e.LongHolidayForIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus).IsUnicode(false);
            entity.Property(e => e.MiltDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherDisease)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PhysicalDisability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyHolderSignature).IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StomachInfection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypesOfOperation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UrineStone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WaistSize)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeightLossOrGain)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenBaby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEarnAbility)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenEduQualification).IsUnicode(false);
            entity.Property(e => e.WomenHusbandMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandName)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandOccupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyCompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenHusbandPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKids)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenKidsExpectation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenLastPeriod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenMonthlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenPayTax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WomenSourceOfIncome)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebApplicantBackup>(entity =>
        {
            entity.ToTable("WebApplicantBackup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApplicantDocumentName).IsUnicode(false);
            entity.Property(e => e.ApplicantDocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantFatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantMotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantNameEng)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApplicantPhotoName).IsUnicode(false);
            entity.Property(e => e.CardType)
                .IsUnicode(false)
                .HasColumnName("card_type");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryCodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.PermanentAddress).IsUnicode(false);
            entity.Property(e => e.PolicyHolderSignature).IsUnicode(false);
            entity.Property(e => e.PolicyRiskAdditonalFactor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyRiskCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RelationCode).IsUnicode(false);
            entity.Property(e => e.StoreAmount).HasColumnName("store_amount");
            entity.Property(e => e.TranCase).IsUnicode(false);
            entity.Property(e => e.TranId)
                .IsUnicode(false)
                .HasColumnName("tran_id");
            entity.Property(e => e.ValId)
                .IsUnicode(false)
                .HasColumnName("val_id");
            entity.Property(e => e.WebApplicantId).HasColumnName("WebApplicantID");
            entity.Property(e => e.YearlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ysapa).HasColumnName("YSAPA");
        });

        modelBuilder.Entity<WebApplicantFamilyHistory>(entity =>
        {
            entity.HasKey(e => e.WebFamilyHistoryId);

            entity.ToTable("WebApplicantFamilyHistory");

            entity.Property(e => e.Age)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AgeDuringDeath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentPhysicalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeathReason)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DurationOfLastIllness)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsPolicy).HasColumnName("isPolicy");
            entity.Property(e => e.LifeStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Relation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WebApplicantDocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YearOfDeath)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebApplicantPolicyInfo>(entity =>
        {
            entity.HasKey(e => e.WebApplicantPolicyId);

            entity.ToTable("WebApplicantPolicyInfo");

            entity.Property(e => e.IsPolicy).HasColumnName("isPolicy");
            entity.Property(e => e.OtherDuePolicySli)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyAccpDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyCondition)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyDuration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtherPolicyRejectInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyPayee)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PolicyReason).IsUnicode(false);
            entity.Property(e => e.PolicyRiskAdditonalFactor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyRiskCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrBmNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceOfIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WedApplicantDocId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YearlyIncome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ysapa).HasColumnName("YSAPA");
        });

        modelBuilder.Entity<WebCorporateSpeech>(entity =>
        {
            entity.HasKey(e => e.CorporateSpeechId);

            entity.ToTable("WebCorporateSpeech");

            entity.Property(e => e.CorporateSpeechEmpType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CorporateSpeechText).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WebDirectorsSpeech>(entity =>
        {
            entity.HasKey(e => e.DirectorId);

            entity.ToTable("WebDirectorsSpeech");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Desination)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesinationBangla).HasMaxLength(100);
            entity.Property(e => e.DirectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DirectorNameBangla).HasMaxLength(100);
            entity.Property(e => e.ImageName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Speech).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WebDptEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("WebDptEmployee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShowStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebFaq>(entity =>
        {
            entity.HasKey(e => e.Faqid);

            entity.ToTable("WebFAQ");

            entity.Property(e => e.Faqid).HasColumnName("FAQid");
            entity.Property(e => e.Answer).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Question).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebFinancialStatement>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Web_FinancialStatement");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileName).IsUnicode(false);
            entity.Property(e => e.StatementType).IsUnicode(false);
            entity.Property(e => e.Title).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebFormDownload>(entity =>
        {
            entity.HasKey(e => e.FormId);

            entity.ToTable("Web_FormDownload");

            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FormDescription).IsUnicode(false);
            entity.Property(e => e.FormDownload)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FormName).IsUnicode(false);
            entity.Property(e => e.HyperlinkName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HyperlinkNameBangla).HasMaxLength(200);
            entity.Property(e => e.PageHyperlink)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WebGroupPass>(entity =>
        {
            entity.ToTable("WebGroupPass");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebLeaveUsMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Web_LeaveUsMessage");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subject).IsUnicode(false);
        });

        modelBuilder.Entity<WebMsg>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("Web_msg");

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesignationBangla).HasMaxLength(100);
            entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.WriterName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WriterNameBangla).HasMaxLength(100);
        });

        modelBuilder.Entity<WebNominee>(entity =>
        {
            entity.ToTable("WebNominee");

            entity.Property(e => e.DocumentId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuardianAddress).IsUnicode(false);
            entity.Property(e => e.IsPolicy).HasColumnName("isPolicy");
            entity.Property(e => e.LegalGuardianNidno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LegalGuardianNIDNo");
            entity.Property(e => e.LegalGuardianNidphoto)
                .IsUnicode(false)
                .HasColumnName("LegalGuardianNIDPhoto");
            entity.Property(e => e.LegalGuardianPhoto).IsUnicode(false);
            entity.Property(e => e.LegalGuardianRelation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NomineeAge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeDob).HasColumnName("NomineeDOB");
            entity.Property(e => e.NomineeGuardianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomineePpname)
                .IsUnicode(false)
                .HasColumnName("NomineePPName");
            entity.Property(e => e.NomineeRelation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UploadDocument).IsUnicode(false);
            entity.Property(e => e.WebApplicantDocId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebPartner>(entity =>
        {
            entity.HasKey(e => e.PartnerId);

            entity.ToTable("Web_Partner");

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnerCheck)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnerDetail).IsUnicode(false);
            entity.Property(e => e.PartnerImage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PartnerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PartnerNameBangla).HasMaxLength(100);
            entity.Property(e => e.PartnerWebsite)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebPaymentHistry>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Web_PaymentHistry");

            entity.HasIndex(e => e.TransectionId, "TransactionId_Web_PaymentHistry_Idx");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SL");
            entity.Property(e => e.ApplicantId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Applicant_id");
            entity.Property(e => e.BranchName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Branch_name");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");
            entity.Property(e => e.FprId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FPR_id");
            entity.Property(e => e.InstallmentNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Installment_number");
            entity.Property(e => e.InstallmentType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LateFees).HasColumnName("Late_fees");
            entity.Property(e => e.NoOfLateFees).HasColumnName("NoOfLate_Fees");
            entity.Property(e => e.OrNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OR_number");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Payment_Method");
            entity.Property(e => e.PaymentPurpose)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Payment_Purpose");
            entity.Property(e => e.PremDueDate).HasColumnName("Prem_due_date");
            entity.Property(e => e.PremiumAmount).HasColumnName("Premium_Amount");
            entity.Property(e => e.TransectionId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Transection_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("User_id");
        });

        modelBuilder.Entity<WebProduct>(entity =>
        {
            entity.HasKey(e => e.Serial);

            entity.ToTable("Web_Products");

            entity.Property(e => e.ChartRate).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InCaseOfAssuredDeath).IsUnicode(false);
            entity.Property(e => e.OnMaturity).IsUnicode(false);
            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.SpecialBenefit).IsUnicode(false);
            entity.Property(e => e.SupplementaryCover).IsUnicode(false);
            entity.Property(e => e.TermOfThePolicy).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YouTubeLink).IsUnicode(false);
        });

        modelBuilder.Entity<WebQuoteTable>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Web_QuoteTable");

            entity.Property(e => e.Cemail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ciplan).HasColumnName("CIPlan");
            entity.Property(e => e.CipolicyAmount).HasColumnName("CIpolicyAmount");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WebShariahBoardSpeech>(entity =>
        {
            entity.HasKey(e => e.DirectorId);

            entity.ToTable("WebShariahBoardSpeech");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Desination)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesinationBangla).HasMaxLength(100);
            entity.Property(e => e.DirectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DirectorNameBangla).HasMaxLength(100);
            entity.Property(e => e.ImageName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Speech).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WebTermsCondition>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Web_TermsCondition");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Heading).IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebUserInfo>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Web_UserInfo");

            entity.Property(e => e.Answer).HasMaxLength(100);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(100)
                .HasColumnName("DocumentID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PolicyId)
                .HasMaxLength(100)
                .HasColumnName("PolicyID");
            entity.Property(e => e.SecQuestion).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Usertype).HasMaxLength(50);
        });

        modelBuilder.Entity<WebsiteDatum>(entity =>
        {
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WebsiteNoticeEvent>(entity =>
        {
            entity.HasKey(e => e.NoticeSl);

            entity.ToTable("WebsiteNoticeEvent");

            entity.Property(e => e.NoticeSl).HasColumnName("NoticeSL");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.EventImage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Heading).IsUnicode(false);
            entity.Property(e => e.PostType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WrongEntry>(entity =>
        {
            entity.ToTable("WrongEntry");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Edate).HasColumnType("datetime");
            entity.Property(e => e.TrnNo).HasMaxLength(255);
        });

        modelBuilder.Entity<Xyz>(entity =>
        {
            entity.ToTable("xyz");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dt");
            entity.Property(e => e.Orid).HasColumnName("orid");
        });

        modelBuilder.Entity<YourTableName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("YourTableName");

            entity.Property(e => e.A2pDeliveryStatus)
                .HasMaxLength(255)
                .HasColumnName("a2pDeliveryStatus");
            entity.Property(e => e.A2pSendSmsBusinessCode).HasColumnName("a2pSendSmsBusinessCode");
            entity.Property(e => e.AnsSendSmsBusinessCode)
                .HasMaxLength(50)
                .HasColumnName("ansSendSmsBusinessCode");
            entity.Property(e => e.AnsSendSmsHttpStatus)
                .HasMaxLength(50)
                .HasColumnName("ansSendSmsHttpStatus");
            entity.Property(e => e.DeliveryStatus)
                .HasMaxLength(255)
                .HasColumnName("deliveryStatus");
            entity.Property(e => e.DndMsisdn)
                .HasMaxLength(255)
                .HasColumnName("dndMsisdn");
            entity.Property(e => e.InvalidMsisdn)
                .HasMaxLength(255)
                .HasColumnName("invalidMsisdn");
            entity.Property(e => e.MnoResponseCode).HasColumnName("mnoResponseCode");
            entity.Property(e => e.MnoResponseMessage)
                .HasMaxLength(255)
                .HasColumnName("mnoResponseMessage");
            entity.Property(e => e.ServerResponseCode).HasColumnName("serverResponseCode");
            entity.Property(e => e.ServerResponseMessage)
                .HasMaxLength(255)
                .HasColumnName("serverResponseMessage");
            entity.Property(e => e.ServerTxnId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serverTxnId");
        });
        modelBuilder.HasSequence<int>("SeqAutoIncrement");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
