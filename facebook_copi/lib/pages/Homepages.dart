// ignore_for_file: file_names

import 'package:flutter/material.dart';

void main() => runApp(const Homepages());

const primaryColor = Color.fromARGB(255, 255, 255, 255);
const grayColor = Color.fromARGB(255, 173, 173, 173);
const fontsColor = Color.fromARGB(255, 43, 43, 43);

class Homepages extends StatelessWidget {
  const Homepages({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final size = MediaQuery.of(context).size;
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home:SafeArea(
        child: Scaffold(
        backgroundColor: Colors.white,
        appBar: PreferredSize(
          preferredSize: Size.fromHeight(130),
          child: Container(
            padding: EdgeInsets.symmetric(horizontal: size.width * 0.04),
            child: Column(
              
              children: [
                Row(
                  children: [
                    Expanded(
                      child: Container(
                        
                        // margin: EdgeInsets.only(top: 10, bottom: 10),
                        child: 
                        Image.asset(
                          
                          'img/face.png',
                        height: 70,
                        )
                        // Image(
                        //   image: NetworkImage(
                        //     'https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Facebook_Logo_%282019%29.svg/2560px-Facebook_Logo_%282019%29.svg.png',
                        //   ),
                        //   height: 25,
                        // ),
                      ),
                    ),
                    Expanded(child: Container()),
                    Icon(Icons.add_circle),
                    SizedBox(width: 5),
                    Icon(Icons.search),
                    SizedBox(width: 5),
                    Icon(Icons.sms),
                  ],
                ),
                Container(
                  // padding: EdgeInsets.symmetric(horizontal: size.width * 0.04),
                  decoration: BoxDecoration(
                    border: Border(
                      bottom: BorderSide(
                        width: 1,
                        color: const Color.fromARGB(255, 95, 95, 95),
                      ),
                    ),
                  ),
                  child: Row(
                    children: [
                      Expanded(child: Icon(Icons.home)),
                      SizedBox(width: 35),
                      Expanded(child: Icon(Icons.ondemand_video)),
                      SizedBox(width: 35),
                      Expanded(child: Icon(Icons.group_outlined)),
                      SizedBox(width: 35),
                      Expanded(child: Icon(Icons.storefront_outlined)),
                      SizedBox(width: 35),
                      Expanded(child: Icon(Icons.notifications_none)),
                      SizedBox(width: 35),
                      Expanded(child: Icon(Icons.menu)),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
        body: SingleChildScrollView(
          child: Column(
            children: [
              Row(
                  children: [
                    Container(
                      decoration: BoxDecoration(
                        
                        borderRadius: BorderRadius.circular(100),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage('https://resources.tidal.com/images/633e1485/97c4/4f56/8b59/1d1c7921a9d3/750x750.jpg'))
                      ),
                     
                     
                      
                      
                      margin: const EdgeInsets.symmetric(horizontal: 10.0),
                      width: 40,
                      height: 40,
                    ),
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(80),
                        color: primaryColor,
                        
                      ),
                      child: Text(
                        "¿Qué estás pensando?",
                        textAlign: TextAlign.left,
                        style: TextStyle(color: fontsColor, fontSize: 16),
                      ),
                      margin: const EdgeInsets.symmetric(horizontal: 2.0),
                      width: 230,
                    
                    ),
                    Expanded(
                      child: Icon(Icons.photo_library,
                          color: Color.fromARGB(255, 9, 219, 37)),
                    ),
                  ],
                ),
              Container(
                // decoration: BoxDecoration(
                  
                //   border: Border(
                //       bottom: BorderSide(
                //         width: 3,
                //         color: grayColor,
                //       ),
                //       top: BorderSide(
                //         width: 3,
                //         color: grayColor,
                //       ),
                //     ),
                // ), 
                margin: const EdgeInsets.symmetric(vertical: 20),
                
                height: 190,
                child: ListView(
                  scrollDirection: Axis.horizontal,
                  children: <Widget>[
                    
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(10),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage("https://okdiario.com/img/2020/07/31/plantilla-okdiario-oficial-12-655x368.jpg"),
                        fit: BoxFit.cover)
                      ),
                      margin: const EdgeInsets.symmetric(horizontal: 2.0),
                      width: 100,
                      child: Align(alignment: Alignment.bottomCenter,
                      child: SizedBox(height: 30,
                      child: Text('Tu Historia',textAlign: TextAlign.end, style: TextStyle(color: primaryColor),),
                      )
                      ,),
                    ),
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(10),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage("https://i.scdn.co/image/ab6761610000e5ebd7f0921a74f6e25c17593201"),
                        fit: BoxFit.cover)
                      ),
                      margin: const EdgeInsets.symmetric(horizontal: 2.0),
                      width: 100,
                       child: Align(alignment: Alignment.bottomCenter,
                      child: SizedBox(height: 30,
                      child: Text('Kidd Keo',textAlign: TextAlign.end, style: TextStyle(color: primaryColor),),
                      )
                      ,),
                    ),
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(10),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage("https://is1-ssl.mzstatic.com/image/thumb/AMCArtistImages112/v4/9f/c3/8a/9fc38aba-bc58-a831-f5b0-b1281e588099/744ee554-b72a-4956-9384-274321c6b9ce_ami-identity-3b6171ac786da31711952722cc41532a-2022-12-01T22-27-49.045Z_cropped.png/375x375bb.jpg"),
                        fit: BoxFit.cover)
                      ),
                      margin: const EdgeInsets.symmetric(horizontal: 2.0),
                      width: 100,
                       child: Align(alignment: Alignment.bottomCenter,
                      child: SizedBox(height: 30,
                      child: Text('Feid',textAlign: TextAlign.end, style: TextStyle(color: primaryColor),),
                      )
                      ,),
                    ),
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(10),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage("data:image/png;base64,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"),
                        fit: BoxFit.cover)
                      ),
                      
                      margin: const EdgeInsets.symmetric(horizontal: 2.0),
                      width: 100,
                       child: Align(alignment: Alignment.bottomCenter,
                      child: SizedBox(height: 30,
                      child: Text('Eladio',textAlign: TextAlign.end, style: TextStyle(color: primaryColor),),
                      )
                      ,),
                    ),
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(10),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage("https://is1-ssl.mzstatic.com/image/thumb/Music118/v4/62/d4/a7/62d4a764-75f9-cf2c-ed3c-7031f5cc083f/192562083208.jpg/1200x1200bf-60.jpg"),
                        fit: BoxFit.cover)
                      ),
                      margin: const EdgeInsets.symmetric(horizontal: 2.0),
                      width: 100,
                       child: Align(alignment: Alignment.bottomCenter,
                      child: SizedBox(height: 30,
                      child: Text('Arcangel',textAlign: TextAlign.end, style: TextStyle(color: primaryColor),),
                      )
                      ,),
                    ),
                    
                    
                  ],
                ),
              ),
              
               
                Row(
                  children: [
                    Container(
                     decoration: BoxDecoration(
                        
                        borderRadius: BorderRadius.circular(100),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage('https://resources.tidal.com/images/633e1485/97c4/4f56/8b59/1d1c7921a9d3/750x750.jpg'))
                      
                      ),
                      
                      margin: const EdgeInsets.symmetric(horizontal: 10.0, vertical: 7.0),
                      width: 40,
                      height: 40,
                    ),
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(80),
                        color: primaryColor,
                        
                      ),
                      child: Text(
                        "Luis Morales",
                        textAlign: TextAlign.left,
                        style: TextStyle(color: fontsColor, fontSize: 16),
                      ),
                      margin: const EdgeInsets.symmetric(horizontal: 2.0, vertical: 7.0),
                      width: 230,
                  
                    ),
                  ],
                ),  
              
              Container(
                padding: EdgeInsets.all(20),
                width: 412,
                height: 460,
                decoration: BoxDecoration(
                  image: DecorationImage(image: NetworkImage('https://resources.tidal.com/images/633e1485/97c4/4f56/8b59/1d1c7921a9d3/750x750.jpg'),fit: BoxFit.cover),
                color: Colors.grey.withOpacity(0.3),
                ),
              ),
             Row(
                  children: [
                    Container(  
                      decoration: BoxDecoration(
                        
                        borderRadius: BorderRadius.circular(100),
                        color: grayColor,
                        image: DecorationImage(image: NetworkImage('https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/Orlando_-_Disney_World_-_Disney%27s_Art_of_Animation_Resort_-_Cars_-_Fillmore_%2817219207365%29.jpg/800px-Orlando_-_Disney_World_-_Disney%27s_Art_of_Animation_Resort_-_Cars_-_Fillmore_%2817219207365%29.jpg'))
                      
                      ),
                      
                      margin: const EdgeInsets.symmetric(horizontal: 10.0, vertical: 7.0),
                      width: 40,
                      height: 40,
                    ),
                    Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(80),
                        color: primaryColor,
                        
                      ),
                      child: Text(
                        "Jhon Hernandez",
                        textAlign: TextAlign.left,
                        style: TextStyle(color: fontsColor, fontSize: 16),
                      ),
                      margin: const EdgeInsets.symmetric(horizontal: 2.0),
                      width: 230,
                  
                    ),
                  ],
                ),  
              
              Container(
                padding: EdgeInsets.all(20),
                width: 412,
                height: 460,
                decoration: BoxDecoration(
                  image: DecorationImage(image: NetworkImage('https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/Orlando_-_Disney_World_-_Disney%27s_Art_of_Animation_Resort_-_Cars_-_Fillmore_%2817219207365%29.jpg/800px-Orlando_-_Disney_World_-_Disney%27s_Art_of_Animation_Resort_-_Cars_-_Fillmore_%2817219207365%29.jpg'),fit: BoxFit.cover),
                color: Colors.grey.withOpacity(0.3),
                ),
              ),
            
              // Aqui más widgets
            ],
          ),
        ),
      ),
    ),
    );
  }
}
