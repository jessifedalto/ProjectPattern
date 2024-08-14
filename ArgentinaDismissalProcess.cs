public class ArgentinaDismissalProcess : DismissalProcess
{
    public override string Title => "Despido de Empleados";
 
    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 3 * args.Employe.Wage;
    }
}