﻿using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class EmailTypeRepository : IEmaiTypeRepository 
    {
        #region Initialization
        // <returns>The list of initializations</returns>
        private readonly BaseDBContext _dbContext;
        public EmailTypeRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Retrieve EmailTypes Asynchronously By ID
        /// <returns>The list of email-types by Id.</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method fetches all email-types by Id from the database using Entity Framework Core.</remarks>
        public async Task<EmailModel> GetByIdAsync(int id)
       {
           try
                {
            var email = await _dbContext.Emails
                .Where(e => e.Id == id)
                .Select(e => new EmailModel
                {
                    Id = e.Id,
                    EmailType = (EmailCategory)e.EmailType
                })
                .FirstOrDefaultAsync();

                return email == null ? throw new KeyNotFoundException($"Email with id {id} not found") : email;
            }
            catch (Exception ex)
        {
            throw new Exception($"Error occurred while fetching email with id {id}: {ex.Message}");
        }
    }
        #endregion

        #region Retrieve EmailTypes Asynchronously
        /// <returns>The list of email-types.</returns>
        /// <exception cref="Exception">Thrown when there is an error while fetching data from the database.</exception>
        /// <remarks>This method fetches all email-types from the database using Entity Framework Core.</remarks>
        public async Task<List<EmailModel>> GetAllAsync()
        {
            try
            {
                var result = await _dbContext.Emails
                    .Select(e => new EmailModel
                    {
                        Id = e.Id,
                        EmailType = (EmailCategory)e.EmailType,
                    }).ToListAsync();

                return result;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error while fetching the database. Please try again later."+ex.Message);
            }
        }
        #endregion

        public Task AddAsync(EmailModel emailType)
        {
            throw new NotSupportedException();
        }

        public Task UpdateAsync(EmailModel emailType)
        {
            throw new NotSupportedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotSupportedException();
        }
    }
}
