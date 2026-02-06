using backend.Data;
using backend.DTOs;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly AppDbContext _context;

        public AuthController(IAuthService authService,AppDbContext context)
        {
            _authService = authService;
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _authService.Login(request);

            if (user == null)
            {
                return Unauthorized(new { message = "Try again.plese check your data" });
            }

            return Ok(new
            {
                message = "Login Successful",
                username = user.Username,
                role = user.Role
            });
        }

        [HttpPost("registerStudent")]
        public async Task<IActionResult> RegisterStudent([FromBody] StudentRegister register)
        {
            if (register == null) return BadRequest("data is null");

            var logindata = new User()
            {
                Username = register.registationNumber,
                PasswordHash = register.password,
                Role = register.role,

            };

            _context.Users.Add(logindata);
            await _context.SaveChangesAsync();

            var newStudent = new Student()
            {
                st_fullname = register.studentName,
                st_email=register.email,
                st_registation_no=register.registationNumber,
                department=register.department,
                faculty=register.faculty,
                academic_year=register.academicYear,
                st_user_id = logindata.Id
            };

            _context.student.Add(newStudent);
           



            await _context.SaveChangesAsync();

            return Ok(new { message = "Registration successful!" });


        }

        [HttpGet("getStudent")]
        public async Task<IActionResult> GetStudent() {
            var students = await _context.student.ToListAsync();
            return Ok(students);
        }

        [HttpPost("addlectures")]
        public async Task<IActionResult> AddLectureToSystem([FromBody] AddLecture addLecture)
        {
            if (addLecture == null) return BadRequest("Data is null");

            var logindata = new User() {
                Username = addLecture.staffId,
                PasswordHash = addLecture.password,
                Role = addLecture.role,

            };
            _context.Users.Add(logindata);
            await _context.SaveChangesAsync();

            var lecturedata = new Lectures() {
                full_name=addLecture.fullName,
                staff_id=addLecture.staffId,
                email=addLecture.email,
                phone_number=addLecture.phoneNumber,
                faculty=addLecture.faculty,
                department=addLecture.department,
                academic_role=addLecture.academicRole,
                user_id = logindata.Id,
            };
            _context.lectures.Add(lecturedata);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Registation successful!" });


           
            

            
        }
        [HttpGet("getlecture")]
        public async Task<IActionResult> Getlecture() { 
            var lecture_data= await _context.lectures.ToListAsync();
            return Ok(lecture_data);
        }

        [HttpPost("addsubject")]
        public async Task<IActionResult> AddSubjectToSystem([FromBody] AddSubjects addSubjects)
        {
            if (addSubjects == null) return BadRequest("data is null");

            var subjectdata = new Subjects()
            {
                Subject_Code = addSubjects.subjectCode,
                Subject_Name = addSubjects.subjectName,
                Credit=addSubjects.credit,
                Academic_Level=addSubjects.academicLevel,
                Semester=addSubjects.semester,
                Type=addSubjects.type,


            };
            _context.subjects.Add(subjectdata);
            await _context.SaveChangesAsync();
            
            return Ok(new { message = "Successful add subjects!" });
        }
    }
}