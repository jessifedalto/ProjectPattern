public class BrazilDismissalProcess : DismissalProcess
{
    public override string Title => "Demissão de Funcionário";

    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 2 * args.Employe.Wage;
    }
}