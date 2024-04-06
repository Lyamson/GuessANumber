pipeline {
    agent any
    stages {
        stage('Stage 1') {
            steps {
                echo 'Hello world!'
            }
        }
		
        stage('Build Solution') {
            steps {
                bat "dotnet build --nologo -c Release -p:ProductVersion=1.0.0.0 --no-restore"
            }
        }
    }
}