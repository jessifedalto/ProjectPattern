public class BrazilAdmissionalProcess : AdmissionalProcess
{
    public override string Title => "Contratação de colaboradores";

    public override void Apply(AdmissionalArgs args)
    {
        args.Company.Money -= args.Employe.Wage;
    }
}