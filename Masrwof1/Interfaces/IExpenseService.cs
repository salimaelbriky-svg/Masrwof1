using Masrwof1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof1.Interfaces
{
    public interface IExpenseService
    {
        Expense GetExpenseById(Guid id);
        void updateExpense(Expense expense);
        List<Expense> GetAllExpenses();
        void AddExpense(Expense expense);
        void DeleteExpense(Guid id);
        decimal GetTotalExpenses();

    }
}
