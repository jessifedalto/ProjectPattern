public class ArgentinaProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess()
        => new ArgentinaDismissalProcess();
 
    public WagePaymentProcess CreateWagePaymentProcess()
        => new ArgentinaWagePaymentProcess();

    public AdmissionalProcess CreateAdmissionalProcess()
        => new ArgentinaAdmissionalProcess();
}