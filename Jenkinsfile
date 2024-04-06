pipeline {
    agent any
	options{
		timestamps()
	}
    stages {
        stage('Restore NuGet For Solution') {
            steps {
                sh "nuget restore --nologo --no-cache"
            }
        }

        stage('Build Solution') {
            steps {
                sh "dotnet build --nologo -c Release -p:ProductVersion=1.0.${env.BUILD_NUMBER}.0 --no-restore"
            }
        }
    }
}