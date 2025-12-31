using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs;
public class ExternalProgramsDB : IExternalProgramsDB
{
	public Task<List<ExternalProgramsDTO>> GetAll()
	{
		throw new NotImplementedException();
	}
}
