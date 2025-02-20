global using MediatR;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.IdentityModel.Tokens;
global using System.Text;
global using FluentValidation;
global using Microsoft.AspNetCore.Mvc;


//Infrastructure


global using Infrastructure.Interfaces;
global using Infrastructure;
global using Infrastructure.Implementations;
global using IAuthenticationService = Infrastructure.Interfaces.IAuthenticationService;
global using AuthenticationService = Infrastructure.Implementations.AuthenticationService;


//Handler
global using Handler;
global using Handler.Extensions;
global using Handler.Dto;
global using Handler.Mediator;

//Domin
global using Domin;
global using Domin.Models;
global using Domin.SignUp;
global using Domin.Login;
global using Domin.Routing.BaseRouter;


//MediatorComman
global using Handler.MediatorHandler.MediatorCommand.Carts;
global using Handler.MediatorHandler.MediatorCommand.Categories;
global using Handler.MediatorHandler.MediatorCommand.CustomProducts;
global using Handler.MediatorHandler.MediatorCommand.Orders;
global using Handler.MediatorHandler.MediatorCommand.Products;
global using Handler.MediatorHandler.MediatorCommand.UserUploads;

//MediatorQuery
global using Handler.MediatorHandler.MediatorQuery.Carts;
global using Handler.MediatorHandler.MediatorQuery.Categories;
global using Handler.MediatorHandler.MediatorQuery.CustomProducts;
global using Handler.MediatorHandler.MediatorQuery.Orders;
global using Handler.MediatorHandler.MediatorQuery.Products;
global using Handler.MediatorHandler.MediatorQuery.UserUploads;
