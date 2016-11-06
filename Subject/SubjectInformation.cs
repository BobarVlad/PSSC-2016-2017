using Models.Generics;

namespace Models.Subject
{
    public class SubjectInformation
    {
        public string Name { get;  set; }
        public Credits Credits { get;internal set; }
        public Professor.Professor Professor { get; set; }
        public Proportion ActivityProportion { get;  set; }
        public EvaluationType Evaluation { get;  set; }

        public SubjectInformation()
        {

        }

        public SubjectInformation(string name, Credits credits, EvaluationType type, Proportion activity)
        {
            Name = name;
            Credits = credits;
            Evaluation = type;
            ActivityProportion = activity;
        }

        public SubjectInformation(string name, Credits credits, EvaluationType type, Proportion activity, Professor.Professor professor) 
            : this(name, credits, type, activity)
        {
            Professor = professor;
        }

        public void SetProfessor(Professor.Professor professor)
        {
            Professor = professor;
        }

        public void SetActivityProportion(Proportion proportion)
        {
            ActivityProportion = proportion;
        }
    }
}
