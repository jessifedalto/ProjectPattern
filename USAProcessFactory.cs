public class USAProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess()
        => new USADismissionalProcess();

    public WagePaymentProcess CreateWagePaymentProcess()
        => new USAWagePaymentProcess();

    public AdmissionalProcess CreateAdmissionalProcess()
        => new USAAdmissionalProcess();
}