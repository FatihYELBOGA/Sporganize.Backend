﻿using Microsoft.AspNetCore.Mvc;
using Sporganize.DTO;
using Sporganize.DTO.Requests;
using Sporganize.DTO.Responses;
using Sporganize.Repositories;
using Sporganize.Services;

namespace Sporganize.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/users-without-details")]
        public List<UserResponse> GetUsersWithoutDetails()
        {
            return _userService.GetWithoutDetails();
        }

        [HttpGet("/users/{id}")]
        public UserResponse GetUserById(int id)
        {
            return _userService.GetById(id);
        }

        [HttpGet("/users/friends/{id}")]
        public List<UserResponse> GetFriends(int id)
        {
            return _userService.GetFriends(id);
        }

        [HttpGet("/users/teams/{id}")]
        public List<TeamResponse> GetTeams(int id)
        {
            return _userService.GetTeams(id);
        }

        [HttpGet("/users/captained-teams/{id}")]
        public List<TeamResponse> GetCaptainedTeams(int id)
        {
            return _userService.GetCaptainedTeams(id);
        }

        [HttpGet("/users/appointments/{id}")]
        public List<AppointmentResponse> GetAppointments(int id)
        {
            return _userService.GetAppointments(id);
        }

        [HttpGet("/users/tournament/{teamId}")]
        public List<TournamentResponse> GetTournamentsByTeamId(int teamId)
        {
            return _userService.GetTournamentsByTeamId(teamId);
        }

        [HttpGet("/users/invitations/{id}")]
        public List<InvitationResponse> GetInvitations(int id)
        {
            return _userService.GetInvitations(id);
        }

        [HttpGet("/users/sport-facilitiles/{id}")]
        public List<SportFacilityResponse> GetSportFacilities(int id)
        {
            return _userService.GetSportFacilities(id);
        }

        [HttpPost("/users/accepted-appointment/{id}")]
        public AppointmentResponse AcceptAppointment(int id, [FromForm] int appointmentId)
        {
            return _userService.AcceptAppointment(id, appointmentId);
        }

        [HttpPut("/users/{id}")]
        public UserResponse Update([FromForm] UserRequest request, int id)
        {
            return _userService.Update(request, id);
        }


    }

}
