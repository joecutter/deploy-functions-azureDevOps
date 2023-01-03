### MXI CI/CD PROOF OF CONCEPT

#### Problem Statement
Deploy several azure function project in c# to azure serverless architecture (Azure function App).

#### Project structure
![Project structure](https://github.com/joecutter/deploy-functions-azureDevOps/blob/dev/Docs/Screenshot%20from%202023-01-03%2014-37-53.png "Project structure")

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

![Project structure](https://github.com/joecutter/deploy-functions-azureDevOps/blob/dev/Docs/Screenshot%20from%202023-01-03%2014-47-36.png "Project structure")

#### Release Stage
Release is categorised into 
- **Dev release** Use dev branch and is triggered by push event.

![Project structure](https://github.com/joecutter/deploy-functions-azureDevOps/blob/dev/Docs/Screenshot%20from%202023-01-03%2015-00-30.png "Project structure")

- **Production release** Uses main branch and is triggered by push request event. Also requires manual permission to build.

![Project structure](https://github.com/joecutter/deploy-functions-azureDevOps/blob/dev/Docs/Screenshot%20from%202023-01-03%2014-50-46.png "Project structure")

#### Recommendation
- Upgrade .NET to the nearest version
- Upgrade azure function to v4
- Use feeds for shared modules and customized library, to avoid code duplication and enable code reusability within internal teams


