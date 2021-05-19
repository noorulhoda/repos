using day1_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace day1_CRUD.Controllers
{
    public class DepartmentController : ApiController
    {
        ITIEntities context = new ITIEntities();

        //http://localhost:52845/api/Department  Get
        public IHttpActionResult GetAll()
        {
            List<Department> depts = context.Department.ToList();
            return Ok<List<Department>>(depts);
        }

        //http:localhos:8989/api/Department/1
        public IHttpActionResult GetbyID(int id)
        {
            Department dept = context.Department.FirstOrDefault(d => d.Dept_Id == id);
            return Ok<Department>(dept);
        }



        ///http:localhos:8989/api/Department/1
        [Route("DeptInstructors/{id}")]
        public IHttpActionResult GetInstructorsbyDeptID(int id)
        {
            Department dept = context.Department.FirstOrDefault(d => d.Dept_Id == id);

            List<string> names = new List<string>();
            names.Add("ahmed");
            names.Add("Ali");

            // Department dept = context.FirstOrDefault(d => d.ID == id);
            return Ok(names);
        }



        //Add NEw Depart
        public IHttpActionResult Post(Department dept)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//400
            }
            try
            {
                context.Department.Add(dept);
                context.SaveChanges();
                //http:localhost:9999/api/department/id

                string urlDetails = Url.Link("DefaultApi", new { id = dept.Dept_Id});
                return Created(urlDetails, "Added Sucess");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);//400

            }
        }


        //http:localhos:8989/api/Department/1
        public IHttpActionResult Put(int id, Department dept)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//400
            }
            try
            {
                Department oldDEpt = context.Department.FirstOrDefault(d => d.Dept_Id == id);
                oldDEpt.Dept_Name = dept.Dept_Name;
                oldDEpt.Dept_Desc= dept.Dept_Desc;
                context.SaveChanges();

                return StatusCode(HttpStatusCode.NoContent);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        public IHttpActionResult DeleteDept(int id)
        {
            try
            {
                Department dept = context.Department.FirstOrDefault(d => d.Dept_Id== id);
                context.Department.Remove(dept);
                context.SaveChanges();
                return Ok("DElete Sucess");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
