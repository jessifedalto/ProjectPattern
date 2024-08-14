public class ArgentinaAdmissionalProcess : AdmissionalProcess
{
    public override string Title => "Contratación de empleados";

    public override void Apply(AdmissionalArgs args)
    {
        args.Company.Money -= args.Employe.Wage;
    }
}