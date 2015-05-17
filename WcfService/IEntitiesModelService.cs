#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Code is generated byTelerik Data Access Service Wizard
// using PlainIDataService.tt template

namespace WcfService
{
	using System.ServiceModel;
	using WcfService.Dto;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	/// <summary>
	/// EntitiesModelService interface.
	/// </summary>
	[ServiceContract]
	public interface IEntitiesModelService
	{
	    #region Accounts CRUD Operations
	
	    /// <summary>
	    /// Returns all accounts.
	    /// </summary>
	    /// <returns></returns>
	    [OperationContract]
	    IEnumerable<AccountDto> ReadAccounts();
	
	    /// <summary>
	    /// Returns a specified amount of accounts from the given start index.
	    /// </summary>
	    /// <param name="startIndex">The start index.</param>
	    /// <param name="pageSize">The returned entities count.</param>
	    /// <returns></returns>
	    [OperationContract]
	    IEnumerable<AccountDto> ReadAccountsPaged(int startIndex, int pageSize);
	
	    /// <summary>
	    /// Returns all accounts filtered by the specified filter expression and sorted by the specified sort expression.
	    /// </summary>
	    /// <param name="sortExpression">The sort expression.</param>
	    /// <param name="filterExpression">The filter expression.</param>
	    /// <returns></returns>
	    [OperationContract]
	    IEnumerable<AccountDto> ReadAccountsFiltered(string sortExpression, string filterExpression);
	
	    /// <summary>
	    /// Returns a specified amount of accounts from the given start index filtered by the specified filter expression and sorted by the specified sort expression.
	    /// </summary>
	    /// <param name="startIndex">The start index.</param>
	    /// <param name="pageSize">The returned entities count.</param>
	    /// <param name="sortExpression">The sort expression.</param>
	    /// <param name="filterExpression">The filter expression.</param>
	    /// <returns></returns>
	    [OperationContract]
	    IEnumerable<AccountDto> ReadAccountsPagedAndFiltered(int startIndex, int pageSize, string sortExpression, string filterExpression);
	
	    /// <summary>
	    /// Returns a account with the specified dto key.
	    /// </summary>
	    /// <param name="dtoKey">The specified dto key value.</param>
	    /// <returns></returns>
	    [OperationContract]
	    AccountDto ReadAccount(string dtoKey);
	
	    /// <summary>
	    /// Returns all accounts count.
	    /// </summary>
	    /// <returns></returns>
	    [OperationContract]
	    int AccountsCount();
	
	    /// <summary>
	    /// Returns all accounts count filtered by the specified filter expression.
	    /// </summary>
	    /// <param name="filterExpression">The filter expression.</param>
	    /// <returns></returns>
	    [OperationContract]
	    int AccountsCountFiltered(string filterExpression);
	
	    /// <summary>
	    /// Adds a new account from the given dto object into the database.
	    /// </summary>
	    /// <param name="account">The dto object.</param>
	    /// <returns>The dto key of the newly created account.</returns>
	    [OperationContract]
	    string CreateAccount(AccountDto account);
	
	    /// <summary>
	    /// Updates account in the database from the given dto object.
	    /// </summary>
	    /// <param name="account">The dto object.</param>
	    [OperationContract]
	    void UpdateAccount(AccountDto account);
	
	    /// <summary>
	    /// Update an existing accounts in the database from the given dto object list.
	    /// </summary>
	    /// <param name="accounts">The dto object list.</param>
	    [OperationContract]
	    void UpdateAccounts(IEnumerable<AccountDto> accounts);
	
	    /// <summary>
	    /// Deletes account from the database by the given dto object.
	    /// </summary>
	    /// <param name="account">The dto object.</param>
	    [OperationContract]
	    void DeleteAccount(AccountDto account);
	
	    /// <summary>
	    /// Delete accounts from the database by the given dto object list.
	    /// </summary>
	    /// <param name="accounts">The dto object list.</param>
	    [OperationContract]
	    void DeleteAccounts(IEnumerable<AccountDto> accounts);
	    
	    #endregion
	    
	}
}
#pragma warning restore 1591