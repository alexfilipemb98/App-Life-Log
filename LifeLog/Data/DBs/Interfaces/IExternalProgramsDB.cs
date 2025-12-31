using LifeLog.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs.Interfaces;
public interface IExternalProgramsDB
{
	Task<List<ExternalProgramsDTO>> GetAll();
}
