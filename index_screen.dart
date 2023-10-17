import 'package:flutter/material.dart';
import 'package:flutter_application_1/Drawer.dart';
import 'bottom_nav.dart';
import 'Drawer.dart';
class indexScreen extends StatelessWidget {
  const indexScreen({super.key});

  @override
  Widget build(BuildContext context) {
   
    return Scaffold(
      appBar: AppBar(title: const Text("Trang chủ")),
      body:const Text ("Index Screen"),
      drawer: const drawer(idx: 0,),
      bottomNavigationBar: const BottomNav(idx:0),
      
    );
  }
}