### MXI CI/CD PROOF OF CONCEPT

#### Problem Statement
Deploy several azure function project in c# to azure serverless architecture (Azure function App).

#### Project structure
![Project structure](./Docs/Screenshot from 2023-01-03 14-37-53.png "Project structure")

#### Solution
- Use Azure devops pipeline.
- Has 2 stages
  1. Build
  2. Deploy/Release

#### Build Stage
- Has 6 steps
  1. Install required .NET runtime
  2. Restore package
  3. Build project
  4. Test project
  5. Publish Test results
  6. Publish build artifacts 

![Project structure](./Docs/Screenshot from 2023-01-03 14-47-36.png "Project structure")

#### Release Stage
Release is categorised into 
- **Dev release** Use dev branch and is triggered by push event.
![Project structure](./Docs/Screenshot from 2023-01-03 15-00-30.png "Project structure")

- **Production release** Uses main branch and is triggered by push request event. Also requires manual permission to build.
![Project structure](./Docs/Screenshot from 2023-01-03 14-50-46.png "Project structure")


