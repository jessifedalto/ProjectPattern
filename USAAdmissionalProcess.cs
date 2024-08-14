public class USAAdmissionalProcess : AdmissionalProcess
{
    public override string Title => "Hiring Employees";

    public override void Apply(AdmissionalArgs args)
    {
        args.Company.Money -= args.Employe.Wage;
    }
}