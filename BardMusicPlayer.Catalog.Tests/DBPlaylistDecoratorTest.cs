﻿using LiteDB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BardMusicPlayer.Notate.Song;

namespace BardMusicPlayer.Catalog.Tests
{
    [TestClass]
    public class DBPlaylistDecoratorTest
    {
        private const string TEST_PLAYLIST_NAME = "Test Playlist";

        [TestMethod]
        public void TestNaming()
        {
            DBPlaylistDecorator test = CreateTestPlaylist();
            Assert.AreEqual(TEST_PLAYLIST_NAME, ((IPlaylist)test).GetName());

            string newName = TEST_PLAYLIST_NAME + " Version 2";
            ((IPlaylist)test).SetName(newName);
            Assert.AreEqual(newName, ((IPlaylist)test).GetName());
        }

        [TestMethod]
        public void TestAddAppend()
        {
            BmpSong songA = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            DBPlaylistDecorator test = CreateTestPlaylist();

            var objRef = test.GetDBPlaylist();
            Assert.AreEqual(0, objRef.Songs.Count);

            ((IPlaylist)test).Add(songA);
            Assert.AreEqual(1, objRef.Songs.Count);
            Assert.AreSame(songA, objRef.Songs[0]);
        }

        [TestMethod]
        public void TestAddInject()
        {
            BmpSong songA = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            BmpSong songB = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            BmpSong songC = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            DBPlaylistDecorator test = CreateTestPlaylist();

            var objRef = test.GetDBPlaylist();

            ((IPlaylist)test).Add(songA);
            ((IPlaylist)test).Add(songB);

            Assert.AreEqual(2, objRef.Songs.Count);
            Assert.AreSame(songA, objRef.Songs[0]);
            Assert.AreSame(songB, objRef.Songs[1]);

            ((IPlaylist)test).Add(1, songC);

            Assert.AreEqual(3, objRef.Songs.Count);
            Assert.AreSame(songA, objRef.Songs[0]);
            Assert.AreSame(songC, objRef.Songs[1]);
            Assert.AreSame(songB, objRef.Songs[2]);
        }

        [TestMethod]
        public void TestMove()
        {
            BmpSong songA = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            BmpSong songB = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            BmpSong songC = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            DBPlaylistDecorator test = CreateTestPlaylist();

            var objRef = test.GetDBPlaylist();

            ((IPlaylist)test).Add(songA);
            ((IPlaylist)test).Add(songB);
            ((IPlaylist)test).Add(songC);

            Assert.AreEqual(3, objRef.Songs.Count);
            Assert.AreSame(songA, objRef.Songs[0]);
            Assert.AreSame(songB, objRef.Songs[1]);
            Assert.AreSame(songC, objRef.Songs[2]);

            ((IPlaylist)test).Move(2, 0);
            Assert.AreEqual(3, objRef.Songs.Count);
            Assert.AreSame(songC, objRef.Songs[0]);
            Assert.AreSame(songA, objRef.Songs[1]);
            Assert.AreSame(songB, objRef.Songs[2]);
        }

        [TestMethod]
        public void TestRemove()
        {
            BmpSong songA = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            BmpSong songB = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            BmpSong songC = new BmpSong()
            {
                Id = ObjectId.NewObjectId()
            };

            DBPlaylistDecorator test = CreateTestPlaylist();

            var objRef = test.GetDBPlaylist();

            ((IPlaylist)test).Add(songA);
            ((IPlaylist)test).Add(songB);
            ((IPlaylist)test).Add(songC);

            Assert.AreEqual(3, objRef.Songs.Count);
            Assert.AreSame(songA, objRef.Songs[0]);
            Assert.AreSame(songB, objRef.Songs[1]);
            Assert.AreSame(songC, objRef.Songs[2]);

            ((IPlaylist)test).Remove(1);
            Assert.AreEqual(2, objRef.Songs.Count);
            Assert.AreSame(songA, objRef.Songs[0]);
            Assert.AreSame(songC, objRef.Songs[1]);
        }

        private static DBPlaylistDecorator CreateTestPlaylist()
        {
            DBPlaylist decorateMe = new DBPlaylist()
            {
                Name = TEST_PLAYLIST_NAME,
                Id = null,
                Songs = new List<BmpSong>()
            };

            return new DBPlaylistDecorator(decorateMe);
        }
    }
}