using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CommandsApi.Dtos;
using CommandsApi.Models;

namespace CommandsApi.Profiles
{
	public class CommandsProfile : Profile
	{
		public CommandsProfile()
		{
			//Source -> Target
			CreateMap<Command, CommandReadDto>();
			CreateMap<CommandCreateDto, Command>();
			CreateMap<CommandUpdateDto, Command>();
			CreateMap<Command, CommandUpdateDto>();
		}

	}
}
