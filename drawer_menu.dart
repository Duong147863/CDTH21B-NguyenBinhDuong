import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter/src/widgets/placeholder.dart';

class DrawerMenu extends StatelessWidget {
  const DrawerMenu({super.key});

  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        children: [
          DrawerHeader(
              child: Row(
            children: [
              Column(
                children: [
                  Container(
                    padding: const EdgeInsets.all(0),
                    width: 100,
                    height: 100,
                    child: const CircleAvatar(
                      backgroundImage: AssetImage("root/assets/img/avt.jpg"),
                    ),
                  ),
                ],
              ),
              Column(
                children: [
                  Container(
                    padding: const EdgeInsets.only(top: 20, left: 20),
                    child: const Text("Neyi"),
                  ),
                ],
              ),
            ],
          )),
          const ListTile(
            leading: Icon(Icons.settings),
            title: Text("Cài đặt"),
          ),
          const ListTile(
            leading: Icon(Icons.question_mark),
            title: Text("Hỗ trợ"),
          ),
          const ListTile(
            leading: Icon(Icons.logout),
            title: Text("Đăng xuất"),
          ),
        ],
      ),
    );
  }
}
