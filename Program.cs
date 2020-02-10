using System;

namespace Operations_Decisions_Loops
{
    class Program
    {
        //Evaluacion parcial
        //Trabajo en clase 25
        //Practicas 25
        //Participacion/Esfuerzo 10
        //Proyecto 40

        //Evaluacion Semestral
        //Trabajo en clase 15
        //Practicas 20
        //Participacion/Esfuerzo 5
        //Proyecto 60
        //limite inferior (minimo) de puntos necesarios para poder tener calificacion semestral

        static float numberThreshold = 6f;
        static float semesterResultAvailableThreshold = 12f;
        static float partialEvaluationWorkInClass = 0.25f;
        static float partialEvaluationPractices = 0.25f;
        static float partialEvaluationParticipation = 0.10f;
        static float partialEvaluationProject = 0.40f;
        static float semesterEvaluationWorkInClass = 0.15f;
        static float semesterEvaluationPractices = 0.20f;
        static float semesterEvaluationParticipation = 0.05f;
        static float semesterEvaluationProject = 0.60f;
        static float PartialEvaluation(float workInCLass, float practice, float participation, 
        float project)
        {
            //Como no es void, debe tener RETURN. Este es un scoupe.
            //Evaluacion parcial
            //Trabajo en clase 25
            //Practicas 25
            //Participacion/Esfuerzo 10
            //Proyecto 40
            //Evaluacion parcial
            //Trabajo en clase 15
            //Practicas 20
            //Participacion/Esfuerzo 5
            //Proyecto 60
            float partialResult = workInCLass * partialEvaluationWorkInClass
            + practice * partialEvaluationPractices 
            + participation * partialEvaluationParticipation 
            + project * partialEvaluationProject;
            //return 0.0f;
            return partialResult;
        }
        static float SemesterEvaluation(float workInCLass, float practice, float participation, float project)
        {
            float SemesterResult = workInCLass * semesterEvaluationWorkInClass
            + practice * semesterEvaluationPractices 
            + participation * semesterEvaluationParticipation
            + project * semesterEvaluationProject;
            return SemesterResult;
        }
            static void Main(string[] args)
            //Este es otro scoupe
            {

                float partial1Result;
                float partial2Result;
                float semesterResult;

                // partial1Result = 10 * partialEvaluationWorkInClass
                // + 10 * partialEvaluationPractices + 10 * partialEvaluationParticipation + 10 * partialEvaluationProject;            
                // Console.WriteLine("partial1Result = " + partial1Result);          
                // partial2Result = 10 * partialEvaluationWorkInClass
                // + 10 * partialEvaluationPractices + 10 * partialEvaluationParticipation + 10 * partialEvaluationProject;
                // Console.WriteLine("partial2Result = " + partial2Result);
                // semesterResult = 10 * semesterEvaluationWorkInClass
                // + 10 * semesterEvaluationPractices + 10 * semesterEvaluationParticipation + 10 * semesterEvaluationProject;
                // Console.WriteLine("semesterResult = " + semesterResult);

                partial1Result = PartialEvaluation(1f, 6f, 4f, 10f);

                Console.WriteLine("partial1Result = " + partial1Result);

                partial2Result = PartialEvaluation(1f, 4f, 10f, 8f);

                Console.WriteLine("partial2Result = " + partial2Result);
                //Si se juntaron 12 puntos en los primeros dos parciales se tiene derecho a calificacion
                //en caso contrario, si no se juntar los 12 puntos el alumno no obtiene derecho a calificacion
                //el 12 inicial es un numero magico, solo el 0 y 1 no son magicos. Se prefiere
                //Nunca utilizarlos

                if (partial1Result >= numberThreshold)
                {
                    Console.WriteLine("partial1Result = " + partial1Result);
                    Console.WriteLine("El alumno esta aprobado en el primer parcial");
                }
                else 
                {
                    Console.WriteLine("partial1Result = " + partial1Result);
                    Console.WriteLine("El alumno esta reprobado en el segundo parcial");
                }
                if (partial2Result >= numberThreshold)
                {
                    Console.WriteLine("partial2Result = " + partial2Result);
                    Console.WriteLine("El alumno esta aprobado en el primer parcial");
                }
                else 
                {
                    Console.WriteLine("partial2Result = " + partial2Result);
                    Console.WriteLine("El alumno esta reprobado en el segundo parcial");
                }

                if (partial1Result + partial2Result >= semesterResultAvailableThreshold)
                {
                    semesterResult = SemesterEvaluation(10f, 10f, 10f, 10f);

                    Console.WriteLine("semesterResult = " + semesterResult);
                } 
                else 
                {
                    semesterResult = 0f;
                    
                    Console.WriteLine("La calificaciones de los parciales no fueron aprobatorias");
                    Console.WriteLine("semesterResult = " + semesterResult);

                }
        } 
    }
}
