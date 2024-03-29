﻿using Gym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.DAL
{
    internal class CourseDAL
    {
        public static List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Course where delete_at is NULL";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Course course = new Course
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetInt32(3)
                    );
                    courses.Add(course);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return courses;
        }
        public static List<Course> SearchCourse(string str)
        {
            List<Course> courses = new List<Course>();
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Course where (courseName LIKE N'%" + str + "%' OR courseID = '" + str + "') and delete_at is NULL "; ;
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Course course = new Course
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetInt32(3)
                    );
                    courses.Add(course);
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return courses;
        }
        public static bool InsertCourse(Course course)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "Insert into Course(courseID,courseName,duration,price)" + 
                    "values (N'" + course._courseID + "',N'" + course._courseName + "',N'" + course._duration + "','" + course._price + "')";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }
        public static bool UpdateCourse(Course course)
        {
            bool result = false;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "update Course set  courseName = N'" + course._courseName + "', duration = N'" +
                     course._duration +  "', price = '" + course._price + "' " + "where courseID = '" + course._courseID + "'";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool DeleteCourse(string ID)
        {
            bool result = false;
            try
            {
                string delete_at = DateTime.Now.ToString("yyyyMMdd");
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                string st = "update Course set delete_at = '" + delete_at + "' where courseID = '" + ID + "'";
                comm.CommandText = st;
                comm.Connection = conn;

                int ret = comm.ExecuteNonQuery();
                if (ret == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static Course GetCourse(string courseID)
        {
            Course course = null;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Course where courseID = '" + courseID + "'";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    course = new Course
                    (
                        rd.GetString(0),
                        rd.GetString(1),
                        rd.GetString(2),
                        rd.GetInt32(3)
                    );
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return course;
        }
        public static string GetLastID()
        {
            string lastID = null;
            try
            {
                SqlConnection conn = new SqlConnection(Program.cnstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 courseID FROM Course ORDER BY courseID DESC";
                cmd.Connection = conn;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lastID = rd.GetString(0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lastID;
        }
    }
}
