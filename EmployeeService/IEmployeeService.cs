using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        Employee GetEmployee(int Id);

        [OperationContract]
        void AddEmployee();

        [OperationContract]
        void DeleteEmployee(int Id);

        [OperationContract]
        void SaveEmployee(Employee employee);

        [OperationContract]
        void UpdateEmployee(Employee employee);

        [OperationContract]
        List<Employee> GetEmployees();

        //[WebGet(UriTemplate = "Employee/Get/{Id}", ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //Employee GetEmployee(int Id);

        //[WebGet(UriTemplate = "Employee/Delete/{Id}", ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //void DeleteEmployee(int Id);

        //[WebGet(UriTemplate = "Employee/List", ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //List<Employee> GetEmployees();

        //[WebGet(UriTemplate = "Employee/Add", ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //void AddEmployee();

        //[WebInvoke(Method = "POST", UriTemplate = "Employee/Save", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //void SaveEmployee(Employee newEmp);

        //[WebInvoke(Method = "POST", UriTemplate = "Employee/Update", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //void UpdateEmployee(Employee newEmp);

        //[WebInvoke(Method = "PUT", UriTemplate = "EmployeePUT", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //void UpdateEmployee(Employee newEmp);

        //[WebInvoke(Method = "DELETE", UriTemplate = "Employee/{empId}", ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //void DeleteEmployee(string empId);

        // TODO: Add your service operations here
    }
}
