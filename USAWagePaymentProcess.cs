public class USAWagePaymentProcess : WagePaymentProcess
{
    public override string Title => "Payment";

    public override void Apply(WagePaymentArgs args)
    {
        args.Company.Money -= 1.65m * args.Employe.Wage;
    }
}