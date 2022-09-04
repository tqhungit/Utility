variable "project" {
  type        = string
  description = "Project name"
}

variable "environment" {
  type        = string
  description = "Environment (dev / stage / prod)"
}

variable "profile" {
  type        = string
  description = "Azure profile"
}

variable "region" {
  type        = string
  description = "Azure region"
  default     = "us-west-1"
}

variable "vpc_cidr_block" {
  type        = string
  description = "VPC CIDR"
}

variable "subnet_public_cidr_block" {
  type        = string
  description = "Public subnet CIDR"
}

variable "subnet_private_cidr_block" {
  type        = string
  description = "Private subnet CIDR"
}



variable "function_name" {
  description = "A unique name for your Lambda Function"
  type        = string
  default     = "UtilityLambdafunctionTest"
}

variable "description" {
  description = "This is an testing lambda"
  type        = string
  default     = ""
}

variable "function_handler" {
  description = "Lambda Function entrypoint in your code"
  type        = string
  default     = "Utility::Utility.Function::FunctionHandler"
}


variable "function_package_path" {
  description = "Path of the Lambda function"
  type        = string
}


variable "runtime" {
  description = "Lambda Function runtime"
  type        = string
  default     = "dotnet6"

  #  validation {
  #    condition     = can(var.create && contains(["nodejs10.x", "nodejs12.x", "java8", "java11", "python2.7", " python3.6", "python3.7", "python3.8", "dotnetcore2.1", "dotnetcore3.1", "dotnet6", "go1.x", "ruby2.5", "ruby2.7", "provided"], var.runtime))
  #    error_message = "The runtime value must be one of supported by AWS Lambda."
  #  }
}