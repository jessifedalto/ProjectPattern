public class USADismissionalProcess : DismissalProcess
{
    public override string Title => "Dismissal of employees";

    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 2 * args.Employe.Wage;
    }
}