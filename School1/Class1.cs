using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{

    internal class Class1
    {
        private static Page1 _reg;
        public static Page1 reg
        {
            get
            {
                if (_reg == null)
                {
                    _reg = new Page1();
                }
                return _reg;
            }
        }
        public static Page3 _autho;
        public static Page3 autho
        {
            get
            {
                _autho = new Page3();
                return _autho;
            }
        }
        public static ManagmentTeacher _managmentTeacher;
        public static ManagmentTeacher managmentTeacher
        {
            get
            {
                _managmentTeacher = new ManagmentTeacher();
                return _managmentTeacher;
            }
        }
        public static ManagmentClass _managmentClass;
        public static ManagmentClass managmentClass
        {
            get
            {
                _managmentClass = new ManagmentClass();
                return _managmentClass;
            }
        }
        public static ManagmentStudent _managmentStudent;
        public static ManagmentStudent managmentStudent
        {
            get
            {
                _managmentStudent = new ManagmentStudent();
                return _managmentStudent;
            }
        }
        public static ManagmentSubject _managmentSubject;
        public static ManagmentSubject managmentSubject
        {
            get
            {
                _managmentSubject = new ManagmentSubject();
                return _managmentSubject;
            }
        }



        private static Page2 _mainWindow;
        public static Page2 mainWindow
        {
            get
            {
                _mainWindow = new Page2();
                return _mainWindow;
            }
        }

        private static adminPage _admin;
        public static adminPage admin
        {
            get
            {
                _admin = new adminPage();
                return _admin;
            }
        }
        private static HeadTeacher _headTeacher;
        public static HeadTeacher headTeacher
        {
            get
            {
                _headTeacher = new HeadTeacher();
                return _headTeacher;
            }
        }
        private static Teacher _teacher;
        public static Teacher teacher
        {
            get
            {
                _teacher = new Teacher();
                return _teacher;
            }
        }
        private static StudentPage _student;
        public static StudentPage studentPage
        {
            get
            {
                _student = new StudentPage();
                return _student;
            }
        }


    }
}
