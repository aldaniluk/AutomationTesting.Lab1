using Logic.Entities;
using Logic.Services;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region students
            Student s1 = new Student("Sasha", "Daniluk",
                new Rating(Subject.Economy, 8, 6),
                new Rating(Subject.Physics, 5, 7),
                new Rating(Subject.Math, 7, 9, 10)
            );

            Student s2 = new Student("Nikita", "Subbot",
                new Rating(Subject.Math, 10, 6),
                new Rating(Subject.Physics, 7, 6, 8, 9)
            );

            Student s3 = new Student("Daria", "Beloded",
                new Rating(Subject.Math, 7, 9, 6),
                new Rating(Subject.Economy, 10, 6, 4, 9, 8)
            );

            Student s4 = new Student("Kate", "Tsurikava",
                new Rating(Subject.Math, 10, 9, 10),
                new Rating(Subject.Economy, 10, 8),
                new Rating(Subject.Physics, 6, 8, 8)
            );

            Student s5 = new Student("Nastya", "Katomakhina",
                new Rating(Subject.Economy, 6, 8, 7),
                new Rating(Subject.Physics, 4, 8, 10, 9)
            );

            Student s6 = new Student("Kolya", "Samusevitch",
                new Rating(Subject.Chemistry, 6, 7),
                new Rating(Subject.Physics, 4, 5, 8)
            );

            Student s7 = new Student("Yura", "Gapanovirch",
                new Rating(Subject.Math, 6, 10, 5),
                new Rating(Subject.Chemistry, 9, 6, 7, 9)
            );

            Student s8 = new Student("Ann", "Levkovitch",
               new Rating(Subject.History, 10, 5),
               new Rating(Subject.Chemistry, 9, 9),
               new Rating(Subject.Literature, 8, 7, 9),
               new Rating(Subject.Sociology, 9)
            );

            Student s9 = new Student("Kate", "Lesina",
               new Rating(Subject.History, 8, 9),
               new Rating(Subject.Geography, 8, 7, 9),
               new Rating(Subject.Sociology, 8, 7)
            );

            Student s10 = new Student("Dana", "Strunevskaya",
                new Rating(Subject.Sociology, 10, 6),
                new Rating(Subject.History, 8, 9, 7, 9, 9),
                new Rating(Subject.Literature, 7, 6, 8, 9)
             );
            #endregion

            #region groups
            Group gr1 = new Group(123, s1, s2);
            Group gr2 = new Group(22, s3, s4);
            Group gr3 = new Group(345, s5, s6);
            Group gr4 = new Group(14, s7, s8);
            Group gr5 = new Group(115, s9, s10);
            #endregion

            #region faculties
            Faculty mmf = new Faculty("MMF", gr1, gr2);
            Faculty raf = new Faculty("RAF", gr3, gr4);
            Faculty ethno = new Faculty("Entology", gr5);
            #endregion

            #region universities
            University bsu = new University("BSU", mmf, raf);
            University bsuca = new University("BSUCA", ethno);
            #endregion

            Console.WriteLine($"Average rating of student {s1.Name} : {s1.CountAverageRating()}");
            Console.WriteLine($"Average rating of student {s1.Name} by Phisics: {s1.CountAverageRatingBySubject(Subject.Physics)}");
            Console.WriteLine($"Average rating of group №{gr1.Number} : {gr1.CountAverageRating()}");
            Console.WriteLine($"Average rating of faculty {mmf.Name} : {mmf.CountAverageRating()}");
            Console.WriteLine($"Average rating of university {bsu.Name} : {bsu.CountAverageRating()}");
            Console.WriteLine($"Average rating of university {bsuca.Name} by History : {bsuca.CountAverageRatingBySubject(Subject.History)}");
        }
    }
}
