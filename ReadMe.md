# Lambda Function Example
The code is implemented with dotnet6.0, NUnit.

# How to deploy

To run this example you need to:
1. Publish the source code and store it at local. you can copy to `Utility\Deployment\build` or wherever
2. Correct file configuration file (`Utility\Deployment\dev\terraform.tfvars`)
3. Execute:

```bash
$ terraform init
$ terraform plan
$ terraform apply
```

