﻿namespace CQRS_İstanbulEğitimAkademi.CQRS.Results.StudentResult
{
    public class GetStudentByIDQueryResult
    {
      
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public decimal? LessonAverage { get; set; }


    }
}
