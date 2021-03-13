resource "aws_dynamodb_table" "weather_table" {
  name           = "weather"
  read_capacity  = 1
  write_capacity = 1
  hash_key       = "Id"

  attribute {
    name = "Id"
    type = "N"
  }
}