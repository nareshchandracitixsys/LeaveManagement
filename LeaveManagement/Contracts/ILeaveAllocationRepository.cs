using LeaveManagement.Data;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface ILeaveAllocationRepository:IRepositoryBase<LeaveAllocation>
    {
        Task<bool> CheckAllocation(int leavetypeid, string employeeid);
        Task<ICollection<LeaveAllocation>> GetLeaveAllocationsByEmployee(string employeeId);
        Task<LeaveAllocation> GetLeaveAllocationsByEmployeeAndType(string employeeId,int leavetypeid);
    }
}
