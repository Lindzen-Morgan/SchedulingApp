﻿using Project1.Models;

namespace Project1.Repositories
{
        public interface ITeacherRepository
        {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
        void SaveChanges();
        }
    
}
