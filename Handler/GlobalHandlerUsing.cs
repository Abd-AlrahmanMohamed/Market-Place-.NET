global using Microsoft.AspNetCore.Http;
global using System.ComponentModel.DataAnnotations;

//Fluent Validation
global using FluentValidation;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics;
global using System.Net;
global using System.Text.Json;

//Mapping
global using AutoMapper;
global using Domin.Models;
global using Handler.Dto;
global using Handler.Extensions;

global using Infrastructure.Interfaces;


//MediatR
global using MediatR;
global using Handler.MediatorHandler.MediatorCommand.Carts;
global using Handler.MediatorHandler.MediatorCommand.Categories;
global using Handler.MediatorHandler.MediatorCommand.CustomProducts;
global using Handler.MediatorHandler.MediatorCommand.Orders;
global using Handler.MediatorHandler.MediatorCommand.Products;
global using Handler.MediatorHandler.MediatorCommand.UserUploads;
global using Handler.MediatorHandler.MediatorQuery.Carts;
global using Handler.MediatorHandler.MediatorQuery.Categories;
global using Handler.MediatorHandler.MediatorQuery.CustomProducts;
global using Handler.MediatorHandler.MediatorQuery.Orders;
global using Handler.MediatorHandler.MediatorQuery.Products;
global using Handler.MediatorHandler.MediatorQuery.UserUploads;
global using Microsoft.Extensions.DependencyInjection;
global using Handler.Mediator;
global using System.Reflection;
global using System.Text.Json;


