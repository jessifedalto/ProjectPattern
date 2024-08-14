public class BrazilProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess()
        => new BrazilDismissalProcess();
 
    public WagePaymentProcess CreateWagePaymentProcess()
        => new BrazilWagePaymentProcess();

    public AdmissionalProcess CreateAdmissionalProcess()
        => new BrazilAdmissionalProcess();
}