pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                git 'https://github.com/akanksha49182/example.git'
            }
        }
        
        stage('Build docker image') {
            steps {
                 
                  powershell 'docker build -f example/Dockerfile -t iamakki/example .'
                     
            }
        }
       
        stage('Deploy') {
            steps {
                powershell 'docker run -p 8081:80 iamakki/example'
            }
        }
        
        
    }
}
