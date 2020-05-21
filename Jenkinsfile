pipeline {
  agent any
  stages {
    stage('Clone') {
      steps {
        git(url: 'https://github.com/josiellps/EnglishAPI', branch: 'develop', credentialsId: 'josiellps')
      }
    }

    stage('Build') {
      steps {
        sh '''export DOTNET_ROOT=/home/pi/dotnet-arm32/
export PATH=$PATH:/home/pi/dotnet-arm32/

dotnet restore
dotnet build'''
      }
    }

    stage('Testes') {
      steps {
        sh 'dotnet test'
      }
    }

    stage('Docker Build') {
      steps {
        sh 'docker build -t englishAPI .'
      }
    }

    stage('Deploy') {
      steps {
        sh 'docker stack deploy --compose-file homolog.yml englishAPI'
      }
    }

  }
}