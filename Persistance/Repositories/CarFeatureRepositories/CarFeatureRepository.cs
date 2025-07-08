using Application.Features.Mediator.Commands.CarFeatureCommands;
using Application.Features.Mediator.Quaries.CarFeatureQuaries;
using Application.Features.Mediator.Results.CarFeatureResults;
using Application.Interfaces.ICarFeatureRepositories;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using Persistance.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CarFeatureRepositories
{
	public class CarFeatureRepository : ICarFeatureRepository
	{
		private readonly CarBookContext _context;

		public CarFeatureRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task CarFeatureChangeStatusFalseByCarAndFeatureId(CarFeatureChangeStatusFalseCommand falseOrTrue)
		{
		    var value = await _context.CarFeatures.Where(x=>x.CarID==falseOrTrue.CarID && x.FeatureID == falseOrTrue.FeatureID).FirstOrDefaultAsync();
			value.Available = false;
			await _context.SaveChangesAsync();
		}

		public async Task CarFeatureChangeStatusTrueByCarAndFeatureId(CarFeatureChangeStatusTrueCommand carFeature)
		{
			var value = await _context.CarFeatures.Where(x => x.CarID == carFeature.CarID && x.FeatureID == carFeature.FeatureID).FirstOrDefaultAsync();
			value.Available = true;
			await _context.SaveChangesAsync();
		}

		
		public async Task<List<GetCarFeatureQueryResult>> GetGetCarFeatureListByCarId(GetCarFeatureQuery result)
		{
			var values= await _context.CarFeatures.Include(x=>x.Feature).Where(z=>z.CarID==result.CarID).ToListAsync();
			return values.Select(x=> new GetCarFeatureQueryResult
			{
				FeatureID = x.FeatureID,
				Available = x.Available,
				CarID = x.CarID,
				FeatureName=x.Feature.Name,
			}).ToList();
		}
	}
}
