using Logic.Entities;

namespace Logic.Services
{
    public static class RatingService
    {
        public static double CountAverageRating(this Student student)
        {
            int total = 0;
            int count = 0;
            foreach(var r in student.Ratings)
            {
                foreach(int m in r.Marks)
                {
                    total += m;
                    count++;
                }
            }
            return count == 0 ? 0 : (double)total / count;
        }

        public static double CountAverageRatingBySubject(this Student student, Subject subject)
        {
            int total = 0;
            int count = 0;
            foreach (var r in student.Ratings)
            {
                if (r.Subj == subject)
                {
                    foreach (int m in r.Marks)
                    {
                        total += m;
                        count++;
                    }
                }
            }
            return count == 0 ? 0 : (double)total / count;
        }

        public static double CountAverageRating(this Group group)
        {
            int total = 0;
            int count = 0;
            foreach (var s in group.Students)
            {
                foreach (var r in s.Ratings)
                {
                    foreach(var m in r.Marks)
                    {
                        total += m;
                        count++;
                    }
                }
                
            }
            return count == 0 ? 0 : (double)total / count;
        }

        public static double CountAverageRating(this Faculty faculty)
        {
            int total = 0;
            int count = 0;
            foreach (var g in faculty.Groups)
            {
                foreach (var s in g.Students)
                {
                    foreach (var r in s.Ratings)
                    {
                        foreach (var m in r.Marks)
                        {
                            total += m;
                            count++;
                        }
                    }
                }
            }
            return count == 0 ? 0 : (double)total / count;
        }

        public static double CountAverageRating(this University university)
        {
            int total = 0;
            int count = 0;
            foreach (var f in university.Faculties)
            {
                foreach (var g in f.Groups)
                {
                    foreach (var s in g.Students)
                    {
                        foreach (var r in s.Ratings)
                        {
                            foreach (var m in r.Marks)
                            {
                                total += m;
                                count++;
                            }
                        }
                    }
                }
            }
            return count == 0 ? 0 : (double)total / count;
        }

        public static double CountAverageRatingBySubject(this University university, Subject subject)
        {
            int total = 0;
            int count = 0;
            foreach (var f in university.Faculties)
            {
                foreach (var g in f.Groups)
                {
                    foreach (var s in g.Students)
                    {
                        foreach (var r in s.Ratings)
                        {
                            if (r.Subj == subject)
                            {
                                foreach (var m in r.Marks)
                                {
                                    total += m;
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            return count == 0 ? 0 : (double)total / count;
        }
    }
}
