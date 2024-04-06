pipeline {
    agent any
    stages {
        stage('Stage 1') {
            steps {
                echo 'Hello world!'
            }
        }
		
        stage('Restore NuGet For Solution') {
            steps {
                //  '--no-cache' to avoid a shared cache--if multiple projects are running NuGet restore, they can collide.
                bat "dotnet restore --nologo --no-cache"
            }
        }
		
        stage('Build Solution') {
            steps {
                bat "dotnet build --nologo -c Release -p:ProductVersion=1.0.0.0 --no-restore"
            }
        }
    }
}