# <img src="https://img.shields.io/badge/-FFFFFF?style=flat-square&logo=duckdb&logoColor=red"/> GatePass
   [![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2FTakeNewcare&count_bg=%23939DAE&title_bg=%2361ACCD&icon=&icon_color=%23E7E7E7&title=hits&edge_flat=false)](https://hits.seeyoufarm.com)
   
<br>

<p align="center">
  <img src ="../main/image/로그인.png"  width="300" height="350" align='left'>
  <img src ="../main/image/결과.png"  width="500" height="350">
</p>


## <img src="https://img.shields.io/badge/-FFFFFF?style=flat-square&logo=googledocs&logoColor=black"/> Project Info
이번 프로젝트는 '대부분의 공정을 사람을 최소화하여 작업하는 스마트 팩토리는 보안이 중요할 것이다는 생각'과 '스마트 팩토리에서 필요하지 않을까?'라는 의문에서 시작한 출입 관리 시스템 프로젝트입니다.<br><br>
관리자 또는 직원이 방문자를 예약하고 방문 기간에 따라 색이 다른 통행증을 발급하는 시스템입니다.<br>
모든 작업은 WINFORM과 
MSSQL을 통하여 제작되었습니다.<br>
<br><br>
Reason for making: studying c#, winform(Guna.UI2), crystal report, MSSQL <br>
Busan Polytechnic High-Tech Course
<br>
<br>

## 개발팀 소개
<table>
  <tr>
    <th>정진영</th>
    <td  rowspan="3">
    안녕하십니까!, 유통업의 물류팀에서 일하는 중 IT 부서 분들과 친해져 해당 분야에 대해 알게되어 늦은 나이에
    high-tech 과정을 통해 새로운 도전과 성장을 꿈꾸고 있습니다.
   <br>
   <br>
    처음 접해보는 분야라 많은 두려움이 있었지만,<br> 오류가 났을 때 스스로 해결해야 직성이 풀리는 저의 성격과 잘 맞아 
    꾸준히 성장하고 있습니다. <br>감사합니다
    </td>
  </tr>
  <tr>
    <td> <img src ="../main/image/me.JPG"  width="200" height="200"></td>
  </tr>
  <tr>
    <td align='center'>wlsdud1525@naver.com</td>
  </tr>
</table>
 
## Stacks
### Environment
<img src="https://img.shields.io/badge/visualstudio-5C2D91?style=flat-square&logo=visualstudio&logoColor=white"/> <img src="https://img.shields.io/badge/github-181717?style=flat-square&logo=github&logoColor=white"/>

### Development
<img src="https://img.shields.io/badge/-C%23-512BD4?logo=Csharp&style=flat&logo=.NET&logoColor=white"/> <img src="https://img.shields.io/badge/-WinForm-FF0000?logo=Csharp&style=flat&logoColor=white"/> <img src="https://img.shields.io/badge/-MSSQL-4479A1?logo=Csharp&style=flat&logoColor=white"/> 



### <img src="https://img.shields.io/badge/-FFFFFF?style=flat-square&logo=airplayvideo&logoColor=black"/>Screen configuration and Description
|로그인|관리자화면|직원화면|
|:---:|:---:|:---:|
|<img src ="../main/image/로그인.png"  width="300" height="300">|<img src ="../main/image/관리자메인.png"  width="400" height="300">|<img src ="../main/image/직원메인.png"  width="400" height="300">|
<br>

|직원 추가|직원 정보 수정|직원 정보|직원 삭제|
|:---:|:---:|:---:|:---:|
|<img src ="../main/image/직원추가.png"  width="300" height="200">|<img src ="../main/image/직원정보수정.png"  width="300" height="200">|<img src ="../main/image/직원정보.png"  width="300" height="200">|<img src ="../main/image/직원삭제.png"  width="300" height="200">|
<br>

|예약 추가|예약 목록|예약 수정|
|:---:|:---:|:---:|
|<img src ="../main/image/방문자 추가.png"  width="300" height="200">|<img src ="../main/image/방문자명단.png"  width="300" height="200">|<img src ="../main/image/방문자 수정.png"  width="300" height="200">|
<br>

|통행증 발급|통행증 프린트|통행증|
|:---:|:---:|:---:|
|<img src ="../main/image/통행증발급.png"  width="300" height="200">|<img src ="../main/image/통행증프린트.png"  width="300" height="300">|<img src ="../main/image/통행증.png"   width="300" height="300">|<img src ="../main/image/result_sale.png"   width="150" height="300">|
<br>

|통행증 구분|빠른 조회|
|:---:|:---:|
|<img src ="../main/image/통행증구분.png"  width="300" height="200">|<img src ="../main/image/빠른조회.png"  width="300" height="200">|



## <img src="https://img.shields.io/badge/-FFFFFF?style=flat-square&logo=googledocs&logoColor=black"/> 개선한 부분
서버에서 데이터를 가져와 Dataset을 이용해 DataGridView에 그대로 붙여넣는 코드는 사용자 관점에서 불필요한 부분이 많았습니다.<br><br>
DataGridView의 열 항목을 편집하여 모든 데이터를 받아오는 대신, 열과 데이터를 연결하고 필요한 부분만 보이게 개선하였습니다.<br>
이때, DataGridView의 행이 생성되지 않는 문제로 인해 데이터 추가 시 기존 데이터에 덮어져 보이지 않은 문제를 행 생성 코드로 해결하였습니다.
<br>


