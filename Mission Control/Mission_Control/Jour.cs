﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Mission_Control
{
    public class Jour
    {
        int num;
        List<Activitée> activitées;

        public Jour(int num)
        {
            this.num = num;
            // journée type
            activitées = new List<Activitée>();

            Activitée a = new Activitée("Living", "Spleeping", 0, 420, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Eating", 420, 480, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Private", 480, 720, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Eating",720, 840, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Private", 840, 1140, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Eating", 1140, 1260, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Private", 1260, 1380, this.num);
            activitées.Add(a);
            a = new Activitée("Living", "Sleeping", 1380, 1480, this.num);
            activitées.Add(a);
        }

        public int getNum()
        {
            return num;
        }

        public void addActivitée(string categorie, string libelle, int tempsdébut, int tempsfin, int numJour){
            Activitée A = new Activitée(categorie,libelle,tempsdébut,tempsfin,numJour);
            activitées.Add(A);
            trierActivitée();
        }

        //ordonne les activiée par ordre chronologique
        public void trierActivitée()
        {
            List<Activitée> tmp = new List<Activitée>();

            foreach (Activitée a in activitées)
            {
                if (tmp.Count == 0)
                {
                    tmp.Add(a);
                }
                else
                {
                    int i = tmp.Count;
                    bool done = false;
                    while(i >= 0 && done == false)
                    {
    
             
                            if (activitées[i - 1].getDebut() > a.getDebut())
                            {
                                i--;
                            }
                            else
                            {
                                tmp.Insert(i, a);
                                done = true;
                            }
                        
                    }
                }
            }

            activitées.Clear();

            foreach (Activitée a in tmp)
            {
                activitées.Add(a);
            }

        }

        public List<Activitée> getActivitées()
        {
            return activitées;
        }

        public void genereXml(XmlDocument xmlDoc, XmlNode rootNode)
        {
            XmlNode nodeJour = xmlDoc.CreateElement("Jour");

            XmlNode nodeNum = xmlDoc.CreateElement("num");
            nodeNum.InnerText = num.ToString();
            nodeJour.AppendChild(nodeNum);


            XmlNode nodeListeActivitee = xmlDoc.CreateElement("ListeActivitee");


            foreach (Activitée a in activitées)
            {
                a.genereXml(xmlDoc, nodeListeActivitee);
            }


            nodeJour.AppendChild(nodeListeActivitee);
            rootNode.AppendChild(nodeJour);
        }
    }
}
