using System.Text.Json.Serialization;

namespace Chores.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoreType
{
  Cleaning,
  Groceries,
  Car,
  Homework,
}