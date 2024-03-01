-- Check if Department table is empty
IF NOT EXISTS (SELECT 1 FROM Department)
BEGIN
    -- Insert data into Department table
    INSERT INTO Department (DepartmentId, DepartmentName, Building)
    VALUES
    ('IT', 'Information Technology', 'Main Building');
END;

-- Check if Class table is empty
IF NOT EXISTS (SELECT 1 FROM Class)
BEGIN
    -- Insert data into Class table
    INSERT INTO Class (ClassId, ClassName, DepartmentId, YearCode)
    VALUES
    ('K44-01', 'CNPM 01', 'IT', 'K44'),
    ('K44-02', 'CNPM 02', 'IT', 'K44'),
    ('K44-03', 'CNPM 03', 'IT', 'K44');
END;

-- Check if Course table is empty
IF NOT EXISTS (SELECT 1 FROM Course)
BEGIN
    -- Insert data into Course table
    INSERT INTO Course (CourseId, CourseName, DepartmentId, CreditNumber)
    VALUES
    ('CT101', 'Basic programming', 'IT', 3),
    ('CT103', 'Data structure', 'IT', 4),
    ('CT251', 'Developing applications on Windows', 'IT', 3);
END;

-- Check if Instructor table is empty
IF NOT EXISTS (SELECT 1 FROM Instructor)
BEGIN
    -- Insert data into Instructor table
    INSERT INTO Instructor (InstructorId, InstructorName, DepartmentId, Password)
    VALUES
    ('001', 'Nguyen Van Cuong', 'IT', '123'),
    ('002', 'Huynh Minh Phuong', 'IT', '123'),
    ('003', 'Thai Cam Nhung', 'IT', '123');
END;

-- Check if Student table is empty
IF NOT EXISTS (SELECT 1 FROM Student)
BEGIN
    -- Insert data into Student table
    INSERT INTO Student (StudentId, StudentName, ClassId)
    VALUES
    ('B18001', 'Pham Thi Bao Nhien', 'K44-01'),
    ('B18002', 'Nguyen Van An', 'K44-01'),
    ('B18003', 'Le Hoai Anh', 'K44-01'),
    ('B18004', 'Nguyen Lam Hoang Anh', 'K44-01'),
    ('B18005', 'Le Minh Bang', 'K44-01'),
    ('B18006', 'Vuong Thua Chan', 'K44-02'),
    ('B18007', 'Cao Cong Danh', 'K44-02'),
    ('B18008', 'Trinh Le Long Duc', 'K44-02'),
    ('B18009', 'Duong Le Minh Hau', 'K44-02'),
    ('B18010', 'Nguyen Vu Hoang', 'K44-02'),
    ('B18011', 'Nguyen Hoang Thai Hoc', 'K44-03'),
    ('B18012', 'Nguyen Quoc Huy', 'K44-03'),
    ('B18013', 'Vo Doan Gia Huy', 'K44-03'),
    ('B18014', 'Vu Thi Bich Huyen', 'K44-03'),
    ('B18015', 'Ho Viet Hung', 'K44-03');
END;

-- Similarly, check and insert data into other tables

-- Check if EvaluationMethod table is empty
IF NOT EXISTS (SELECT 1 FROM EvaluationMethod)
BEGIN
    -- Insert data into EvaluationMethod table
    INSERT INTO EvaluationMethod (EvaluationMethodName, Weight)
    VALUES
    ('Midterm Exam', 40), -- Weight of 40% for Midterm Exam
    ('Final Exam', 60);   -- Weight of 60% for Final Exam
END;

-- Check if AcademicYears table is empty
IF NOT EXISTS (SELECT 1 FROM AcademicYears)
BEGIN
    -- Insert data into AcademicYears table
    INSERT INTO AcademicYears (Year, Semester, StartDate, EndDate, IsActive, Description)
    VALUES
    (2023, 'First', '2023-08-21', '2023-12-15', 1, 'Fall Semester 2023'),
    (2024, 'Second', '2024-01-16', '2024-05-10', 0, 'Spring Semester 2024'),
    (2024, 'Summer', '2024-06-03', '2024-08-10', 0, 'Summer Session 2024');
END;

-- Check if TimeSlots table is empty
IF NOT EXISTS (SELECT 1 FROM TimeSlots)
BEGIN
    -- Insert data into TimeSlots table
    INSERT INTO TimeSlots (StartTime, EndTime, DaysOfWeek)
    VALUES
    ('08:00:00', '09:30:00', 'MWF'),
    ('10:00:00', '11:30:00', 'TR');
END;

-- Check if Sections table is empty
IF NOT EXISTS (SELECT 1 FROM Sections)
BEGIN
    -- Insert data into Sections table
    INSERT INTO Sections (CourseId, AcademicYearTermId, ClassNumber)
    VALUES
    ('CT101', 1, 'A101'), -- Basic Programming for K44-01
    ('CT101', 1, 'A102'), -- Basic Programming for K44-02
    ('CT103', 1, 'A201'), -- Data Structures for K44-01
    ('CT103', 1, 'A202'), -- Data Structures for K44-02
    ('CT251', 1, 'B101'), -- Windows App Dev for K44-01
    ('CT251', 1, 'B102'), -- Windows App Dev for K44-02
    ('CT251', 1, 'B103'); -- Windows App Dev for K44-03 
END;

-- Check if Enrollments table is empty
IF NOT EXISTS (SELECT 1 FROM Enrollments)
BEGIN
    -- Insert data into Enrollments table
    INSERT INTO Enrollments (StudentId, SectionId)
    VALUES
    -- K44-01 students enrolled in their class sections:
    ('B18001', 1), ('B18001', 3), ('B18001', 5),
    ('B18002', 2), ('B18002', 4), ('B18002', 6),
    ('B18003', 2), ('B18003', 4), ('B18003', 6),
    ('B18004', 1), ('B18004', 3), ('B18004', 5),
    ('B18005', 1), ('B18005', 3), ('B18005', 5),

    -- K44-02 students enrolled in their class sections:
    ('B18006', 2), ('B18006', 4), ('B18006', 7),
    ('B18007', 2), ('B18007', 4), ('B18007', 7),
    ('B18008', 2), ('B18008', 4), ('B18008', 7),
    ('B18009', 2), ('B18009', 4), ('B18009', 7),
    ('B18010', 2), ('B18010', 4), ('B18010', 7);

    -- K44-03 students enrolled in their class sections:
    INSERT INTO Enrollments (StudentId, SectionId)
    VALUES
    -- CT101 - Basic Programming
    ('B18011', 1), ('B18011', 7), -- Assuming there are two sections for CT101 in K44-03
    ('B18012', 1), ('B18012', 7),
    ('B18013', 1), ('B18013', 7),
    ('B18014', 1), ('B18014', 7),
    ('B18015', 1), ('B18015', 7),

    -- CT103 - Data Structures
    ('B18011', 6), -- Assuming there is one section for CT103 in K44-03
    ('B18012', 6),
    ('B18013', 6),
    ('B18014', 6),
    ('B18015', 6),

    -- CT251 - Windows Application Development
    ('B18011', 3), -- Assuming there is one section for CT251 in K44-03
    ('B18012', 3),
    ('B18013', 3),
    ('B18014', 3),
    ('B18015', 3);
END;

-- Check if Teaches table is empty
IF NOT EXISTS (SELECT 1 FROM Teaches)
BEGIN
    -- Insert data into Teaches table
    INSERT INTO Teaches (InstructorId, SectionId, IsPrimary)
    VALUES
    -- Mr. Nguyen Van Cuong teaches Basic Programming for K44-01 and K44-02 (primary instructor)
    ('001', 1, 1), -- Section 1 for CT101 in K44-01 (assuming primary)
    ('001', 2, 1), -- Section 2 for CT101 in K44-02 (assuming primary)

    -- Mr. Nguyen Van Cuong teaches Data Structures for K44-01 and K44-03 (primary instructor)
    ('001', 4, 1), -- Section 4 for CT103 in K44-01 (assuming primary)
    ('001', 6, 1), -- Section 6 for CT103 in K44-03 (assuming primary)

    -- Mr. Huynh Minh Phuong teaches Basic Programming for K44-03 (not primary)
    ('002', 7, 0), -- Section 7 for CT101 in K44-03

    -- Mr. Huynh Minh Phuong teaches Data Structures for K44-02 (not primary)
    ('002', 5, 0), -- Section 5 for CT103 in K44-02

    -- Ms. Thai Cam Nhung teaches Windows application development for all 3 classes (primary instructor)
    ('003', 1, 1), -- Section 1 for CT251 in K44-01 (assuming primary)
    ('003', 2, 1), -- Section 2 for CT251 in K44-02 (assuming primary)
    ('003', 3, 1); -- Section 3 for CT251 in K44-03 (assuming primary)
END;

-- Check if Grades table is empty
IF NOT EXISTS (SELECT 1 FROM Grades)
BEGIN
    -- Insert data into Grades table
    INSERT INTO Grades (StudentId, SectionId, EvaluationMethodId, Grade)
    VALUES
    -- Grades for enrollments in CT101 (Basic Programming) with Midterm Exam and Final Exam
    -- Replace the values with actual StudentIds, SectionIds, and EvaluationMethodIds
    ('B18001', 1, 1, 8.5),  -- Grade for Student B18001 in Section 1 (CT101) with Midterm Exam
    ('B18001', 1, 2, 9.0),  -- Grade for Student B18001 in Section 1 (CT101) with Final Exam
    ('B18002', 1, 1, 7.8),  -- Grade for Student B18002 in Section 1 (CT101) with Midterm Exam
    ('B18002', 1, 2, 8.2),  -- Grade for Student B18002 in Section 1 (CT101) with Final Exam
    ('B18003', 1, 1, 9.2),  -- Grade for Student B18003 in Section 1 (CT101) with Midterm Exam
    ('B18003', 1, 2, 8.8),  -- Grade for Student B18003 in Section 1 (CT101) with Final Exam
    -- Add more grades for CT101 enrollments if needed

    -- Grades for enrollments in CT103 (Data Structures) with Midterm Exam and Final Exam
    -- Replace the values with actual StudentIds, SectionIds, and EvaluationMethodIds
    ('B18001', 3, 1, 6.7),  -- Grade for Student B18001 in Section 3 (CT103) with Midterm Exam
    ('B18001', 3, 2, 7.1),  -- Grade for Student B18001 in Section 3 (CT103) with Final Exam
    ('B18002', 3, 1, 8.1),  -- Grade for Student B18002 in Section 3 (CT103) with Midterm Exam
    ('B18002', 3, 2, 8.5),  -- Grade for Student B18002 in Section 3 (CT103) with Final Exam
    ('B18003', 3, 1, 7.5),  -- Grade for Student B18003 in Section 3 (CT103) with Midterm Exam
    ('B18003', 3, 2, 8.0);  -- Grade for Student B18003 in Section 3 (CT103) with Final Exam
END;
