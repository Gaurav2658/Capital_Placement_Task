using TaskConsole.Enums;
using System.ComponentModel.DataAnnotations;
namespace TaskConsole.Models;

public class Application : BaseModel
{
    public string ApplicationCoverImage {get; set;}
    public string FirstName{get; set;}
    public string LastName {get; set;}
    public string EmailAddress {get; set;}
    public string PhoneNumber {get; set;}
    public string Nationality {get; set;}
    public string CurrentResidence {get; set;}
    public string IdNumber {get; set;}
    public DateTime DateOfBirth {get; set;}
    public Gender Gender {get; set;}
    public Profile Profile {get; set;}
    public Stage Stage {get; set;}
    public string StageId {get; set;}
    public TaskConsole.Models.Program Program {get; set;}
    public string ProgramId {get; set;}
}
