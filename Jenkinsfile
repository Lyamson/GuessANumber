pipeline {
    agent any
	options{
		timestamps()
	}
    stages {
        stage('Restore NuGet For Solution') {
            steps {
                sh "nuget restore"
            }
        }

        stage('Build Solution') {
            steps {
                sh "dotnet build"
            }
        }
    }
}
